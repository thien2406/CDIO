namespace WebApplication1.Models
{
    public class EnergyMonitoringModel
    {
        public double VoltageInput { get; set; }
        public double CurrentInput { get; set; }
        public double VoltageBatteryMin { get; set; }
        public double VoltageBatteryMax { get; set; }
        public int CurrentCharging { get; set; }
        public int BatteryPercent { get; set; }
        public double Voltage { get; set; }
        public double MinVoltage { get; set; }
        public double MaxVoltage { get; set; }

        public double Current { get; set; }
        public double MinCurrent { get; set; }
        public double MaxCurrent { get; set; }

        // Phương thức để đảm bảo giá trị nằm trong giới hạn đã đặt
        public void SetVoltage(double value)
        {
            if (value < MinVoltage)
                Voltage = MinVoltage;
            else if (value > MaxVoltage)
                Voltage = MaxVoltage;
            else
                Voltage = value;
        }

        public void SetCurrent(double value)
        {
            if (value < MinCurrent)
                Current = MinCurrent;
            else if (value > MaxCurrent)
                Current = MaxCurrent;
            else
                Current = value;
        }
        public void UpdateVoltage(double newVoltage)
        {
            SetVoltage(newVoltage);
        }

        public void UpdateCurrent(double newCurrent)
        {
            SetCurrent(newCurrent);
        }
        // Thêm các thuộc tính khác tương ứng với dữ liệu bạn muốn hiển thị
    }
}
