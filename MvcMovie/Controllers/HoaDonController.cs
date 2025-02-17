using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HoaDonController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        [HttpPost]
        public IActionResult Index(float SoLuong, float DonGia)
        {
            string strOutput = "Số lượng đơn hàng: " + SoLuong + " Đơn giá là: " + DonGia;
            ViewBag.Message1 = strOutput;
            float Gia = SoLuong*DonGia;
            string strGia = "Tiền hóa đơn: " + Gia;
            ViewBag.Message2 = strGia;
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}