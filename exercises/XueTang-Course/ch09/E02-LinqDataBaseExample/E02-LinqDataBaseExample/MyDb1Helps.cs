using System;
using System.Linq;
namespace E02_LinqDataBaseExample
{
    class MyDb1Helps
    {
        public static bool SaveChanges(MyDb1Entities c, out string errorMsg)
        {
            bool isSuccess = false;
            errorMsg = null;
            try
            {
                c.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                errorMsg = $"{ex.Message}\n";
                var exceptionType = ex.GetType();
                if (ex is System.Data.Entity.Validation.DbEntityValidationException ex1)
                {
                    errorMsg += "\n【EntityValidationErrors属性】的信息如下：\n";
                    var q = from t in ex1.EntityValidationErrors select t;
                    foreach (var v in q)
                    {
                        foreach (var v1 in v.ValidationErrors)
                        {
                            errorMsg += $"{v1.ErrorMessage}\n";
                        }
                    }
                }
                if (ex is System.Data.Entity.Infrastructure.DbUpdateException ex2)
                {
                    errorMsg += "\n【内部异常】信息如下：\n";
                    var inner = ex2.InnerException;
                    if (inner != null)
                    {
                        if (inner.InnerException != null)
                        {
                            errorMsg += inner.InnerException.Message;
                        }
                        else
                        {
                            errorMsg += inner.Message;
                        }
                    }
                }
            }
            return isSuccess;
        }
    }
}
