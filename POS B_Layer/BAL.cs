using POS_DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_DataLayer;

namespace POS_B_Layer
{
    
   public class BAL
    {
       
       public bool checkValidationfor_ItemLookupCode(string ItemLookupCode)
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               var ItmLookupCode = (from d in context.Items where d.ItemLookupCode == ItemLookupCode select d).Count();
               if (ItmLookupCode > 0)
                   return true;
               return false;
           }
       }

       public bool checkValidationfor_SupplierList(int ItemID, int supplierID)
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               var CountSupplier = (from sup_list in context.SupplierLists
                          where sup_list.ItemID == ItemID && sup_list.SupplierID == supplierID
                          select sup_list).Count();

               if (CountSupplier > 0)
                   return true;
               return false;
           }
       } 

       public int GetMaxitemID()
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               var a = context.Items.Max(o => o.ID);
               return a;
           }
       }
      
       public string addOrUpdateItems(Item item,SupplierList sup_List)
       {
           using (var context = new storeEntities(ConString.getconstring()))
           {
               string MessageString="";
               DAL data = new POS_DataLayer.DAL();
              if(checkValidationfor_ItemLookupCode(item.ItemLookupCode))
              {
                  try
                  {       

                      if (item.SupplierID == 0)
                      {
                          if (data.updateItem(item))
                          {
                              MessageString = "Item successfully Update.";
                          }
                      }
                      else
                      {
                          if (data.UpdatetItem_Transaction(item, sup_List))
                          {
                              MessageString = "Item successfully Update.";
                          }
                      }


                  }
                  catch (Exception ex)
                  {
                      MessageString = ex.Message;
                  }

                  
              }
              else
              {
                  try
                  {                    
                     
                      if (item.SupplierID == 0)
                      {
                          if (data.InsertItems(item))
                          {
                              MessageString = "Item successfully insert.";
                          }
                         
                      }
                      else
                      {
                          if (data.insertItem_Transaction(item, sup_List))
                          {
                              MessageString = "Item successfully insert.";
                          }
                      }

                      
                  }
                  catch(Exception ex)
                  {
                      MessageString= ex.Message;
                  }

              }
              return MessageString;
           }
       }
    }
}
