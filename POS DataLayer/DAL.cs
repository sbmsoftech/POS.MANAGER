using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;


namespace POS_DataLayer
{
   public class DAL
    {
       public List<Department> getdepartment()
       {
           using(var context=new storeEntities(ConString.getconstring()))
           {
               List<Department> dep=new List<Department>();
               var list = from d in context.Departments select d;
               dep.Add(new Department {  Name = "None", ID =0 });
               foreach(var a in list)
               {
                   dep.Add(new Department{code=a.code,Name=a.Name,ID=a.ID,HQID=a.HQID,DBTimeStamp=a.DBTimeStamp});
               }
               return dep.ToList();
           }
       }    
       public List<Category> Getcategory(int DepartmentID)
       {
           using(var context=new storeEntities(ConString.getconstring()))
           {
               List<Category> cate = new List<Category>();
               var list = from d in context.Categories where d.DepartmentID == DepartmentID select d;
               if(list.Count()>0)
               {
                   cate.Add(new Category { Name = "None", ID = 0 });
                   foreach (var a in list)
                   {
                       cate.Add(new Category { Name = a.Name, ID = a.ID, HQID = a.HQID, DBTimeStamp = a.DBTimeStamp, Code = a.Code, DepartmentID = a.DepartmentID });
                   }
               }
               else
               {
                   cate.Add(new Category { Name = "None", ID = 0 });
                   foreach (var a in list)
                   {
                       cate.Add(new Category { Name = a.Name, ID = a.ID, HQID = a.HQID, DBTimeStamp = a.DBTimeStamp, Code = a.Code, DepartmentID = a.DepartmentID });
                   }
               }
               
               return cate.ToList();
           }    
       }
       public List<Supplier> Getsupplires()
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               List<Supplier> supplire = new List<Supplier>();
               var list = from d in context.Suppliers select d;
               supplire.Add(new Supplier { SupplierName = "None", ID = 0 });
               foreach(var l in list)
               {
                   supplire.Add(new Supplier { SupplierName = l.SupplierName, ID = l.ID });
               }              
               return supplire.ToList();
           }
       }
       public List<Tax> Gettax()
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               List<Tax> taxList = new List<Tax>();
               var list = from d in context.Taxes select d;

               taxList.Add(new Tax { Description = "None", ID = 0 });
               foreach(var t in list)
               {
                   taxList.Add(new Tax { Description = t.Description, ID = t.ID });
               }               
               return taxList.ToList();
           }
       }
       public List<Alias> GetAliases()
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {             
               var list = from d in context.Aliases select d;
               return list.ToList();
           }
       }
      
       public List<Item> getData_useCode(string ItemLookupCode)
       {          
           using (var context = new storeEntities(ConString.getconstring()))
           {
               var ItmLookupCode = from  d in context.Items
                                     
                                   where d.ItemLookupCode == ItemLookupCode 
                                   select d;

               return ItmLookupCode.ToList();
           }
       }
       public List<SupplierList> getSupplierList_ItemlookupCode(int ItemID,int supplierID)
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               var list = from sup_list in context.SupplierLists

                          where sup_list.ItemID == ItemID && sup_list.SupplierID == supplierID
                          select sup_list;

               return list.ToList();
           }
       }
       public bool InsertItems(Item itm)
       {          
           using (var context = new storeEntities(ConString.getconstring()))
           {
               context.Items.Add(itm);
               context.SaveChanges();
               return true;
           }
       }
       public bool insertItem_Transaction(Item itm,SupplierList sup_List)
       {
           using(var context=new storeEntities(ConString.getconstring()))
           {
               using(var transaction=context.Database.BeginTransaction())
               {
                   try
                   {
                       context.Items.Add(itm);
                       context.SaveChanges();
                       sup_List.ItemID = itm.ID;
                       context.SupplierLists.Add(sup_List);
                       context.SaveChanges();
                       transaction.Commit();
                       return true;
                   }
                   catch
                   {
                                          
                       transaction.Rollback();
                       return false;
                   }
               }
           }
           
       }

       public bool updateItem(Item itm)
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               var query = (from i in context.Items where i.ItemLookupCode == itm.ItemLookupCode select i).First();

               query.Description = itm.Description;
               query.DepartmentID = itm.DepartmentID;
               query.CategoryID = itm.CategoryID;
               query.SupplierID = itm.SupplierID;
               query.Cost = itm.Cost;
               query.Price = itm.Price;
               query.MSRP = itm.MSRP;
               query.Quantity = itm.Quantity;
               query.RestockLevel = itm.RestockLevel;
               query.ReorderPoint = itm.ReorderPoint;
               query.TaxID = itm.TaxID;
               query.BarcodeFormat = itm.BarcodeFormat;
               query.SaleType = itm.SaleType;
               query.SalePrice = itm.SalePrice;
               query.PictureName = itm.PictureName;
               query.WebItem = itm.WebItem;
               query.PriceMustBeEntered = itm.PriceMustBeEntered;
               query.ExtendedDescription = itm.ExtendedDescription;
               query.SubDescription1 = itm.SubDescription1;
               query.SubDescription2 = itm.SubDescription2;
               query.SubDescription3 = itm.SubDescription3;
               context.SaveChanges();
               return true;
           }
       }

       public bool UpdatetItem_Transaction(Item itm, SupplierList sup_List)
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               using (System.Data.Entity.DbContextTransaction transaction = context.Database.BeginTransaction())
               {
                   try
                   {
                       var query = (from i in context.Items where i.ItemLookupCode == itm.ItemLookupCode select i).First();
                       query.Description = itm.Description;
                       query.DepartmentID = itm.DepartmentID;
                       query.CategoryID = itm.CategoryID;
                       query.SupplierID = itm.SupplierID;
                       query.Cost = itm.Cost;
                       query.Price = itm.Price;
                       query.MSRP = itm.MSRP;
                       query.Quantity = itm.Quantity;
                       query.RestockLevel = itm.RestockLevel;
                       query.ReorderPoint = itm.ReorderPoint;
                       query.TaxID = itm.TaxID;
                       query.BarcodeFormat = itm.BarcodeFormat;
                       query.SaleType = itm.SaleType;
                       query.SalePrice = itm.SalePrice;
                       query.PictureName = itm.PictureName;
                       query.WebItem = itm.WebItem;
                       query.PriceMustBeEntered = itm.PriceMustBeEntered;
                       query.ExtendedDescription = itm.ExtendedDescription;
                       query.SubDescription1 = itm.SubDescription1;
                       query.SubDescription2 = itm.SubDescription2;
                       query.SubDescription3 = itm.SubDescription3;


                       var q2 = (from s in context.SupplierLists where s.SupplierID == itm.SupplierID && s.ItemID == query.ID select s).First();

                       q2.MasterPackQuantity = sup_List.MasterPackQuantity;
                       q2.MinimumOrder = sup_List.MinimumOrder;
                       q2.ReorderNumber = sup_List.ReorderNumber;
                       q2.TaxRate = sup_List.TaxRate;

                       context.SaveChanges();
                       transaction.Commit();
                      
                       return true;
                   }
                   catch
                   {
                       transaction.Rollback();
                       return false;
                   }
               }
           }

       }

              
    }
}
