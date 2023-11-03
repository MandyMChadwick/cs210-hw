
/*
@page
@model IndexModel

using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public List<string> FileList { get; set; }  // Replace with your actual model

    public void OnGet()
    {
        // Populate FileList with your model data
        FileList = GetFileList();  // Implement this method to get your file list
    }
}







<select id="idSelector">
    @foreach (var item in Model.FileList)
    {
        <option value="@item">@item</option>
    }
</select>


*/