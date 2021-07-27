using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Radzen;
using Radzen.Blazor;
using Net5Wasm.Api.Models;
using Microsoft.AspNetCore.Components.Forms;




namespace Net5Wasm.Pages
{


    public partial class UploadfilesandsaveComponent
    {
        //EventConsole console;

        RadzenUpload upload;

        int progress;
        string info;

        int customParameter = 1;
        private void OnProgress(UploadProgressArgs args, string v)
        {
            throw new NotImplementedException();

            this.info = $"% '{v}' / {args.Loaded} of {args.Total} bytes.";
            this.progress = args.Progress;

            if (args.Progress == 100)
            {
                //console.Clear();

                foreach (var file in args.Files)
                {
                    //console.Log($"Uploaded: {file.Name} / {file.Size} bytes");
                }
            }

        }


    }
}
