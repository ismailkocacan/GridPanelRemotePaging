using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Ext.Net.MVC;

namespace GridPanelRemotePaging.Controllers
{
    public class GridPanelPagingController : Controller
    {
        //
        // GET: /GridPanelPaging/

        public ActionResult Index()
        {
            return View(new List<VmStock>());
        }



        private List<VmStock> CreateMockData()
        {
            List<VmStock> data = new List<VmStock>();
            for (int i = 1; i <= 1000; i++)
            {
                data.Add(new VmStock() { id = i, Name = "Stock " + i, UnitPrice = i + 1, Amount = 2 });
            }
            return data;
        }

        public ActionResult GetData(int start, int limit, int page)
        {
            List<VmStock> allData = CreateMockData();
            page--;
            var data = allData.Skip(limit * page).Take(limit);

            StoreResult result = this.Store(data);
            result.Total = allData.Count;
            return result;
        }
    }
}
