using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class EnergyDashboardModel : PageModel
    {
        public EnergyMonitoringModel EnergyData { get; set; }

        public EnergyDashboardModel()
        {
            EnergyData = new EnergyMonitoringModel();

        }

        public void OnGet()
        {
            EnergyData.VoltageBatteryMin = 7; // Giả định này là giá trị bạn muốn hiển thị
            EnergyData.VoltageBatteryMax = 14.1; // Giả định này là giá trị bạn muốn hiển thị
            EnergyData.CurrentCharging = 30; // Giả định này là giá trị bạn muốn hiển thị
            EnergyData.Voltage = 0; // Giá trị ban đầu cho ví dụ
            EnergyData.Current = 0;
        }

    }

}
