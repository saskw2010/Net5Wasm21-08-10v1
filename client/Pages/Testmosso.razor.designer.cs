using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Net5Wasm.Models.Net5Wasmconn;
using Microsoft.AspNetCore.Identity;
using Net5Wasm.Models;
using Net5Wasm.Client.Pages;

namespace Net5Wasm.Pages
{
    public partial class TestmossoComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SecurityService Security { get; set; }

        [Inject]
        protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        protected Net5WasmconnService Net5Wasmconn { get; set; }
        protected RadzenDataList<Net5Wasm.Models.Net5Wasmconn.Category> datalist0;

        bool _hasChanges;
        protected bool hasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                if (!object.Equals(_hasChanges, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "hasChanges", NewValue = value, OldValue = _hasChanges };
                    _hasChanges = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if (!object.Equals(_canEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "canEdit", NewValue = value, OldValue = _canEdit };
                    _canEdit = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Radzen.ODataServiceResult<Net5Wasm.Models.Net5Wasmconn.Category> _categorylist;
        protected Radzen.ODataServiceResult<Net5Wasm.Models.Net5Wasmconn.Category> categorylist
        {
            get
            {
                return _categorylist;
            }
            set
            {
                if (!object.Equals(_categorylist, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "categorylist", NewValue = value, OldValue = _categorylist };
                    _categorylist = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Net5Wasm.Models.Net5Wasmconn.Category> _getCategoriesResult;
        protected IEnumerable<Net5Wasm.Models.Net5Wasmconn.Category> getCategoriesResult
        {
            get
            {
                return _getCategoriesResult;
            }
            set
            {
                if (!object.Equals(_getCategoriesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCategoriesResult", NewValue = value, OldValue = _getCategoriesResult };
                    _getCategoriesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getCategoriesCount;
        protected int getCategoriesCount
        {
            get
            {
                return _getCategoriesCount;
            }
            set
            {
                if (!object.Equals(_getCategoriesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCategoriesCount", NewValue = value, OldValue = _getCategoriesCount };
                    _getCategoriesCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Security.InitializeAsync(AuthenticationStateProvider);
            if (!Security.IsAuthenticated())
            {
                UriHelper.NavigateTo("Login", true);
            }
            else
            {
                await Load();
            }
        }
        protected async System.Threading.Tasks.Task Load()
        {
            hasChanges = false;

            canEdit = true;

            var net5WasmconnGetCategoriesResult = await Net5Wasmconn.GetCategories();
            categorylist = net5WasmconnGetCategoriesResult;
        }

        protected async System.Threading.Tasks.Task Datalist0LoadData(LoadDataArgs args)
        {
            var net5WasmconnGetCategoriesResult = await Net5Wasmconn.GetCategories(top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
            getCategoriesResult = net5WasmconnGetCategoriesResult.Value.AsODataEnumerable();

            getCategoriesCount = net5WasmconnGetCategoriesResult.Count;
        }
    }
}
