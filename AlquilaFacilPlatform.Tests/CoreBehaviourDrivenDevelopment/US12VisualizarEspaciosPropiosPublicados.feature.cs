﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AlquilaFacilPlatform.Tests.CoreBehaviourDrivenDevelopment
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class VisualizarEspaciosPropiosPublicadosFeature : object, Xunit.IClassFixture<VisualizarEspaciosPropiosPublicadosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "US12VisualizarEspaciosPropiosPublicados.feature"
#line hidden
        
        public VisualizarEspaciosPropiosPublicadosFeature(VisualizarEspaciosPropiosPublicadosFeature.FixtureData fixtureData, AlquilaFacilPlatform_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CoreBehaviourDrivenDevelopment", "Visualizar espacios propios publicados", "  Como arrendador,\r\n  Quiero poder visualizar todos los espacios que he publicado" +
                    " en la plataforma,\r\n  Para gestionar fácilmente la información de mis propiedade" +
                    "s.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Listado de espacios publicados")]
        [Xunit.TraitAttribute("FeatureTitle", "Visualizar espacios propios publicados")]
        [Xunit.TraitAttribute("Description", "Listado de espacios publicados")]
        [Xunit.InlineDataAttribute("Espacio 1", "Ubicación 1", new string[0])]
        [Xunit.InlineDataAttribute("Espacio 2", "Ubicación 2", new string[0])]
        [Xunit.InlineDataAttribute("Espacio 3", "Ubicación 3", new string[0])]
        public void ListadoDeEspaciosPublicados(string nombre, string ubicacion, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("nombre", nombre);
            argumentsOfScenario.Add("ubicación", ubicacion);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Listado de espacios publicados", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
    testRunner.Given("que el arrendador ha iniciado sesión", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
    testRunner.When("accede a la sección \"Mis espacios\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
    testRunner.Then(string.Format("puede ver una lista de todos los espacios publicados con {0} y {1}", nombre, ubicacion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Acceso a detalles")]
        [Xunit.TraitAttribute("FeatureTitle", "Visualizar espacios propios publicados")]
        [Xunit.TraitAttribute("Description", "Acceso a detalles")]
        [Xunit.InlineDataAttribute("Espacio 1", "Aforo = 5, Ubicación = Ubicación 1, Precio = 100, Descripción = Descripción 1", new string[0])]
        [Xunit.InlineDataAttribute("Espacio 2", "Aforo = 10, Ubicación = Ubicación 2, Precio = 200, Descripción = Descripción 2", new string[0])]
        [Xunit.InlineDataAttribute("Espacio 3", "Aforo = 15, Ubicación = Ubicación 3, Precio = 300, Descripción = Descripción 3", new string[0])]
        public void AccesoADetalles(string espacio, string detalles, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("espacio", espacio);
            argumentsOfScenario.Add("detalles", detalles);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Acceso a detalles", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
    testRunner.Given("que visualiza la lista de espacios", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
    testRunner.When(string.Format("selecciona un {0}", espacio), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
    testRunner.Then(string.Format("puede acceder a los {0} de este mismo", detalles), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                VisualizarEspaciosPropiosPublicadosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                VisualizarEspaciosPropiosPublicadosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
