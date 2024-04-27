using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class DashboardModel : PageModel
    {
        public float PowerOut { get; set; }
        public int BatteryPercent { get; set; }
        public float VoltageInput { get; set; }
        public float CurrentInput { get; set; }
  

       
    }
}