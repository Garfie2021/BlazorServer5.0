using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorDownloadFile;

namespace WebApplication1.Pages.Base
{
    partial class PageBase
    {
        [Inject] protected IBlazorDownloadFileService BlazorDownloadFileService { get; set; }

        [Inject] protected NavigationManager _NavigationManager { get; set; }
        [Inject] protected IJSRuntime JsRuntime { get; set; }
    }
}


