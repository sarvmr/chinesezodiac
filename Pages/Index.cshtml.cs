using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace chinesezodiac.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int yearInput { get; set; }
    public string resultText { get; set; }
    public string images { get; set; }

    public void OnGet(){
        //Console.WriteLine(yearInput);
    }

    public void OnPost(){
        if (1900 > yearInput || yearInput > 2024){
            resultText = "Type between 1900 and 2024";
        }else {
            resultText = Utils.GetZodiac(yearInput % 12);
            images = "/images/" + resultText + ".png";
        }
    }
}
