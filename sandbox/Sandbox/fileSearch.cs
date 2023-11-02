
/*
@page
@model IndexModel

<h1>File List</h1>

<ul>
    @foreach (var file in Model.Files)
    {
        <li>
            <a href="javascript:void(0)" class="file-link" data-file="@file">@file</a>
        </li>
    }
</ul>

<div id="file-details"></div>

@section scripts {
    <script>
        $(document).ready(function () {
            $('.file-link').click(function () {
                var fileName = $(this).data('file');
                $.ajax({
                    type: 'GET',
                    url: '/Index?handler=GetFileDetails',
                    data: { fileName: fileName },
                    success: function (data) {
                        $('#file-details').html(data);
                    }
                });
            });
        });
    </script>
}



using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileListApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<string> Files { get; set; }

        public async Task OnGet()
        {
            // Replace with the path to your folder
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "YourFolderPath");

            Files = Directory.GetFiles(folderPath)
                .Select(Path.GetFileName)
                .ToList();
        }

        public IActionResult OnGetGetFileDetails(string fileName)
        {
            // Replace this with code to retrieve information from the database based on the fileName
            var fileDetails = GetFileDetailsFromDatabase(fileName);

            return Content(fileDetails);
        }

        private string GetFileDetailsFromDatabase(string fileName)
        {
            // Replace this with your database retrieval logic
            return $"Details for {fileName} from the database.";
        }
    }
}
*/