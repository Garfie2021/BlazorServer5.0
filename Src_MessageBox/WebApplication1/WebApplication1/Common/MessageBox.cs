using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components;
using Blazored.Modal;
using Blazored.Modal.Services;
using WebApplication1.Modal;


namespace WebApplication1
{
    /// <summary>
    /// Windows Form の MessageBoxリスペクト クラス
    /// </summary>
    public class MessageBox
    {
        private IModalService Modal;

        public MessageBox(IModalService modal)
        {
            Modal = modal;
        }

        /// <summary>
        /// 確認画面表示
        /// </summary>
        public async Task<ModalResult> Show(string caption, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(ModalMessageBox.Message), text);
            parameters.Add(nameof(ModalMessageBox.MessageDetail), null);
            parameters.Add(nameof(ModalMessageBox.Buttons), buttons);
            parameters.Add(nameof(ModalMessageBox.Icon), icon);

            var moviesModal = Modal.Show<ModalMessageBox>(caption, parameters);
            var result = await moviesModal.Result;

            return result;
        }

        public async Task<ModalResult> Show(string caption, string text, string textDetail, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(ModalMessageBox.Message), text);
            parameters.Add(nameof(ModalMessageBox.MessageDetail), textDetail);
            parameters.Add(nameof(ModalMessageBox.Buttons), buttons);
            parameters.Add(nameof(ModalMessageBox.Icon), icon);

            var moviesModal = Modal.Show<ModalMessageBox>(caption, parameters);
            var result = await moviesModal.Result;

            return result;
        }

    }
}
