using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        [HttpPost]
        public IActionResult Index(float DiemA, float DiemB, float DiemC)
        {
            string strOutput = "Điểm A= " + DiemA + " Điểm B= " + DiemB + " Điểm C= " + DiemC;
            ViewBag.Message1 = strOutput;

            // Tính điểm trung bình với trọng số đúng
            float Avr = DiemA * 0.6f + DiemB * 0.3f + DiemC * 0.1f;
            string strAvr = "Điểm trung bình của bạn là: " + Avr;

            // Xếp loại theo điểm trung bình
            if (Avr >= 8.5)
            {
                strAvr = "Điểm trung bình của bạn là: " + Avr + " - Xếp loại Giỏi";
            }
            else if (Avr >= 6.5 && Avr < 8.5)
            {
                strAvr = "Điểm trung bình của bạn là: " + Avr + " - Xếp loại Khá";
            }
            else if (Avr >= 5.0 && Avr < 6.5)
            {
                strAvr = "Điểm trung bình của bạn là: " + Avr + " - Xếp loại Trung bình";
            }
            else
            {
                strAvr = "Điểm trung bình của bạn là: " + Avr + " - Xếp loại Yếu";
            }

            ViewBag.Message2 = strAvr;
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}