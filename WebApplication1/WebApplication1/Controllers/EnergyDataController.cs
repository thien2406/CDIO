using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; // Tham chiếu đúng đến namespace của EnergyData

[Route("api/[controller]")]
[ApiController]
public class EnergyDataController : ControllerBase
{
    // GET: api/EnergyData
    [HttpGet]
    public IActionResult GetEnergyData()
    {
        // Tạo một instance của EnergyData
        var energyData = new EnergyData
        {
            BatteryPercent = 84,
            VoltageInput = 0.22454,
            CurrentInput = 0.0,
            VoltageOutput = 12.90844
            // Khởi tạo các thuộc tính khác
        };

        return Ok(energyData);
    }

    // POST: api/EnergyData
    [HttpPost]
    public IActionResult PostEnergyData([FromBody] EnergyData data)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Xử lý và lưu trữ 'data' vào cơ sở dữ liệu hoặc thiết bị
        // Giả sử rằng bạn có một property 'Id' trong EnergyData
        // Nếu không có, bạn cần bỏ qua phần này hoặc thêm nó vào class EnergyData
        // return CreatedAtAction("GetEnergyData", new { id = data.Id }, data);

        return Ok(data); // Trả về dữ liệu nhận được cho mục đích giả định
    }
}
