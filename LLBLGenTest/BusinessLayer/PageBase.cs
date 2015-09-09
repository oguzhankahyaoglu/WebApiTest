using System.Web.UI;

namespace LLBLGenTest.Application
{
    public class PageBase : Page
    {
        public T Data<T>()
        {
            return (T) GetDataItem();
        }
    }
}