﻿/***************************************************************************

Copyright (c) 2008 Microsoft Corporation. All rights reserved.

***************************************************************************/

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.PowerCommands.Common
{
    /// <summary>
    /// Helper class for VSShell common operations
    /// </summary>
    public static class VSShellHelper
    {
        /// <summary>
        /// Gets the selected hierarchy.
        /// </summary>
        /// <returns></returns>
        public static IVsHierarchy GetSelectedHierarchy()
        {
            IntPtr ptr;
            IntPtr ptr2;
            uint num;
            IVsMultiItemSelect select;
            IVsHierarchy hierarchy = null;

            IVsMonitorSelection selection = Package.GetGlobalService(typeof(IVsMonitorSelection)) as IVsMonitorSelection;

            if(selection.GetCurrentSelection(out ptr, out num, out select, out ptr2) == 0)
            {
                if(ptr != IntPtr.Zero)
                {
                    hierarchy = Marshal.GetObjectForIUnknown(ptr) as IVsHierarchy;

                    Marshal.Release(ptr);
                }
            }

            return hierarchy;
        }

        /// <summary>
        /// Shows a message box.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="text">The text.</param>
        /// <param name="helpKeyword">The help keyword.</param>
        /// <returns></returns>
        public static DialogResult ShowMessageBox(string title, string text, string helpKeyword)
        {
            return ShowMessageBox(title, text, helpKeyword, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows a message box.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="text">The text.</param>
        /// <param name="helpKeyword">The help keyword.</param>
        /// <param name="buttons">The buttons.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public static DialogResult ShowMessageBox(string title, string text, string helpKeyword, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            IVsUIShell uiShellService = Package.GetGlobalService(typeof(SVsUIShell)) as IVsUIShell;

            int pnResult = 1;

            if(uiShellService != null)
            {
                Guid empty = Guid.Empty;
                OLEMSGBUTTON msgbtn = (OLEMSGBUTTON)buttons;
                OLEMSGICON msgicon = OLEMSGICON.OLEMSGICON_INFO;

                switch(icon)
                {
                    case MessageBoxIcon.Question:
                        msgicon = OLEMSGICON.OLEMSGICON_QUERY;
                        break;

                    case MessageBoxIcon.Exclamation:
                        msgicon = OLEMSGICON.OLEMSGICON_WARNING;
                        break;

                    case MessageBoxIcon.Asterisk:
                        msgicon = OLEMSGICON.OLEMSGICON_INFO;
                        break;

                    case MessageBoxIcon.None:
                        msgicon = OLEMSGICON.OLEMSGICON_NOICON;
                        break;

                    case MessageBoxIcon.Hand:
                        msgicon = OLEMSGICON.OLEMSGICON_CRITICAL;
                        break;
                }

                uiShellService.ShowMessageBox(
                    0,
                    ref empty,
                    title,
                    string.IsNullOrEmpty(text) ? null : text,
                    helpKeyword,
                    0,
                    msgbtn,
                    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST,
                    msgicon,
                    0,
                    out pnResult);
            }

            return (DialogResult)pnResult;
        }
    }
}