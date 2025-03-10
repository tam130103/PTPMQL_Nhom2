using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ 
        [HttpPost]
        public IActionResult Index(float ChieuCao, float CanNang)
        {
            string strOutput = "Cân nặng của bạn là: " + CanNang + " Chiều cao của bạn là: " + ChieuCao;
            ViewBag.Message1 = strOutput;
            float BMI = CanNang / (ChieuCao * ChieuCao);
            string strBMI = "Chỉ số BMI của bạn là: " + BMI;
            if (BMI < 18.5)
            {
                strBMI = "BMI của bạn là: " + BMI + " Bạn đang gầy";
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                strBMI = "BMI của bạn là: " + BMI + " Bạn đang bình thường";
            }
            else if (BMI >= 25 && BMI < 29.9)
            {
                strBMI = "BMI của bạn là: " + BMI + " Bạn đang tiền béo phì";
            }
            else if (BMI >= 30 && BMI < 34.9)
            {
                strBMI = "BMI của bạn là: " + BMI + " Bạn đang béo phì độ 1";
            }
            else if (BMI >= 35 && BMI < 39.9)
            {
                strBMI = "BMI của bạn là: " + BMI + " Bạn đang béo phì độ 2";
            }
            else if (BMI >= 40)
            {
                strBMI = "BMI của bạn là: " + BMI + " Bạn đang béo phì độ 3";
            }

            ViewBag.Message2 = strBMI;
            return View();
        }

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}