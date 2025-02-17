using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace MvcMovie.Models;

public class HoaDon
{
    public string? SoLuongSoLuong  {get; set; }

    public string? DonGia {get; set; }

}