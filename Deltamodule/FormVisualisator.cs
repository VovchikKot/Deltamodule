using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Deltamodule
{
    class FormVisualisator
    {
        

        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CreateViewer(ref string x, ref string y);

        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ChangeViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ChangeTopOnMaxViewer(string x);

        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern bool VisibleViewer ( bool x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void SizeViewer(string x);

        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CloseViewer(string x);

        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CopyCutMassiveInViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ChangeIniCoordViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ChangeScreenViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ChangeParamViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void OpenTimy(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CloseTimy(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void FocusMainViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void OpenFlashTimy(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatViewerShow();
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatViewerHide(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatChangeCoordinate(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatActivateViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatChangeTopOnMaxViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatCloseViewer();
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void SetupInCadrDpoRegim(string x);

        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatVisibleViewer();
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void GranatChangeDeltaViewer();
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CalculBitGroupErrorHide(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void NumberCadrs(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void UnVisibleCodeText(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void WindowsPosViewerTable(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void NotRedrawAndRun();
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ProbaProc(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void MarkerRegCurrentMassive(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void WindowsPosViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void SelfApplicationKeyDown(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ClickMainHotKeys(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ProcedureOperationChangeSpeed(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void BringToFrontViewerTA(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void PosViewerTA(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void LoadWindowsViewerTA();
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void LoadWindowsPosUnicViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void SaveWindowsPosUnicViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CopyCutMassiveInViewerForTmp(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void CopyAndCutMassiveInViewer(string x);
        [DllImport("GraView.dll", CallingConvention = CallingConvention.StdCall,
            CharSet = CharSet.Ansi)]
        public static extern void ComStrCreateViewer();
      
        

    }
    
        
}
