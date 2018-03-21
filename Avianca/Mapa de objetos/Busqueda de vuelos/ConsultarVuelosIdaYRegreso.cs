﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Avianca.Mapa_de_objetos.Busqueda_de_vuelos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ConsultarVuelosIdaYRegreso recording.
    /// </summary>
    [TestModule("8b3da90c-a62d-478e-a47c-8a4941872256", ModuleType.Recording, 1)]
    public partial class ConsultarVuelosIdaYRegreso : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Avianca.AviancaRepository repository.
        /// </summary>
        public static Avianca.AviancaRepository repo = Avianca.AviancaRepository.Instance;

        static ConsultarVuelosIdaYRegreso instance = new ConsultarVuelosIdaYRegreso();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConsultarVuelosIdaYRegreso()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConsultarVuelosIdaYRegreso Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.avianca.com/co/es/' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.avianca.com/co/es/", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnColombiaVuelosNacionalesEInternac.BkOrigen' at 97;24.", repo.EnColombiaVuelosNacionalesEInternac.BkOrigenInfo, new RecordItemIndex(1));
            repo.EnColombiaVuelosNacionalesEInternac.BkOrigen.Click("97;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Medellín' with focus on 'EnColombiaVuelosNacionalesEInternac.BkOrigen'.", repo.EnColombiaVuelosNacionalesEInternac.BkOrigenInfo, new RecordItemIndex(2));
            repo.EnColombiaVuelosNacionalesEInternac.BkOrigen.PressKeys("Medellín");
            Delay.Milliseconds(12900);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'EnColombiaVuelosNacionalesEInternac.BkOrigen'.", repo.EnColombiaVuelosNacionalesEInternac.BkOrigenInfo, new RecordItemIndex(3));
            repo.EnColombiaVuelosNacionalesEInternac.BkOrigen.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'EnColombiaVuelosNacionalesEInternac.BkOrigen'.", repo.EnColombiaVuelosNacionalesEInternac.BkOrigenInfo, new RecordItemIndex(4));
            repo.EnColombiaVuelosNacionalesEInternac.BkOrigen.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnColombiaVuelosNacionalesEInternac.BkDestino' at 100;29.", repo.EnColombiaVuelosNacionalesEInternac.BkDestinoInfo, new RecordItemIndex(5));
            repo.EnColombiaVuelosNacionalesEInternac.BkDestino.Click("100;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Bogotá' with focus on 'EnColombiaVuelosNacionalesEInternac.BkDestino'.", repo.EnColombiaVuelosNacionalesEInternac.BkDestinoInfo, new RecordItemIndex(6));
            repo.EnColombiaVuelosNacionalesEInternac.BkDestino.PressKeys("Bogotá");
            Delay.Milliseconds(3670);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'EnColombiaVuelosNacionalesEInternac.BkDestino'.", repo.EnColombiaVuelosNacionalesEInternac.BkDestinoInfo, new RecordItemIndex(7));
            repo.EnColombiaVuelosNacionalesEInternac.BkDestino.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'EnColombiaVuelosNacionalesEInternac.BkDestino'.", repo.EnColombiaVuelosNacionalesEInternac.BkDestinoInfo, new RecordItemIndex(8));
            repo.EnColombiaVuelosNacionalesEInternac.BkDestino.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnColombiaVuelosNacionalesEInternac.BkFechaIda' at 155;19.", repo.EnColombiaVuelosNacionalesEInternac.BkFechaIdaInfo, new RecordItemIndex(9));
            repo.EnColombiaVuelosNacionalesEInternac.BkFechaIda.Click("155;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}' with focus on 'EnColombiaVuelosNacionalesEInternac.BkFechaIda'.", repo.EnColombiaVuelosNacionalesEInternac.BkFechaIdaInfo, new RecordItemIndex(10));
            repo.EnColombiaVuelosNacionalesEInternac.BkFechaIda.PressKeys("{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '21032018' with focus on 'EnColombiaVuelosNacionalesEInternac.BkFechaIda'.", repo.EnColombiaVuelosNacionalesEInternac.BkFechaIdaInfo, new RecordItemIndex(11));
            repo.EnColombiaVuelosNacionalesEInternac.BkFechaIda.PressKeys("21032018");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnColombiaVuelosNacionalesEInternac.BkFechaRegreso' at Center.", repo.EnColombiaVuelosNacionalesEInternac.BkFechaRegresoInfo, new RecordItemIndex(12));
            repo.EnColombiaVuelosNacionalesEInternac.BkFechaRegreso.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '26032018' with focus on 'EnColombiaVuelosNacionalesEInternac.BkFechaRegreso'.", repo.EnColombiaVuelosNacionalesEInternac.BkFechaRegresoInfo, new RecordItemIndex(13));
            repo.EnColombiaVuelosNacionalesEInternac.BkFechaRegreso.PressKeys("26032018");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EnColombiaVuelosNacionalesEInternac.Consultar' at Center.", repo.EnColombiaVuelosNacionalesEInternac.ConsultarInfo, new RecordItemIndex(14));
            repo.EnColombiaVuelosNacionalesEInternac.Consultar.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.BeginLocationContainer'", repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.BeginLocationContainerInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.BeginLocationContainerInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n\n\n\n\n\n\n\n') on item 'TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.EndLocationContainer'.", repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.EndLocationContainerInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.EndLocationContainerInfo, "InnerText", "\n\n\n\n\n\n\n\n");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n\n\n\n\n\n\n\n') on item 'TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.BeginLocationContainer1'.", repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.BeginLocationContainer1Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.BeginLocationContainer1Info, "InnerText", "\n\n\n\n\n\n\n\n");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='\n\n\n\n\n\n\n\n') on item 'TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.EndLocationContainer1'.", repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.EndLocationContainer1Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.TiquetesAereosEnVuelosNacionalesEI.RowCalendarmatrixModifydatesPanelCal.EndLocationContainer1Info, "InnerText", "\n\n\n\n\n\n\n\n");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
