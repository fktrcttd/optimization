using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Microsoft.SolverFoundation.Services;
using Optimization.Models;

namespace Optimization.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var furnances = GetDefaultFurnances();
            var optimizationModel = new OptimizationModel()
            {
                CoxCost = 1.8,
                CoxSupply = 520,
                GasCost = 0.6,
                GasSupply = 120000,
                Furnaces = furnances,
                RequiredIronPerformance = 1100
            };

            optimizationModel = Solve(optimizationModel);

            return View(optimizationModel);
        }

        [HttpPost]
        public ActionResult Index(OptimizationModel model)
        {
            try
            {
                for (var index = 0; index < model.Furnaces.Count; index++)
                {
                    var modelFurnace = model.Furnaces[index];
                    modelFurnace.FurnanceId = index;
                }

                model = Solve(model);
                var solvedModel = new OptimizationModel();
                solvedModel.Furnaces = model.Furnaces;
                solvedModel.CoxCost = model.CoxCost;
                solvedModel.GasCost = model.GasCost;
                solvedModel.GasSupply = model.GasSupply;
                solvedModel.CoxSupply = model.CoxSupply;
                solvedModel.OptimizedFunctionResult = model.OptimizedFunctionResult;
                solvedModel.RequiredIronPerformance = model.RequiredIronPerformance;
                ViewBag.MessageResult = $"Рассчитанная целевая функция:  {solvedModel.OptimizedFunctionResult}";

                return View(solvedModel);

            }
            catch (Exception e)
            {
                ViewBag.MessageResult = "При расчете произошла ошибка. Проверьте входные данные";
                return View(model);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private List<BlastFurnace> GetDefaultFurnances()
        {
            var f1 = new BlastFurnace()
            {
                FurnanceId = 0,
                GasExpenseBasePeriod = 15000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 64.25,
                CoxReplacementEquivalent = 0.59,
                IronPerformance = 146.4,
                TheoreticTemperatureBasePeriod = 1938,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 10000,
                DeltaIronPerformanceGasChanged = -0.0007295,
                DeltaIronPerformanceCoxChanged = -0.00297,
                DeltaTemperatureGasChanged = -0.0265
                
            };
            
            var f2 = new BlastFurnace()
            {
                FurnanceId = 1,
                GasExpenseBasePeriod = 17000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod =66.76,
                CoxReplacementEquivalent = 0.53,
                IronPerformance = 136.4,
                TheoreticTemperatureBasePeriod = 1959,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 13039.3258426966,
                DeltaIronPerformanceGasChanged = -0.0006695,
                DeltaIronPerformanceCoxChanged = -0.00297,
                DeltaTemperatureGasChanged = -0.0356
            };
            
            var f3 = new BlastFurnace()
            {
                FurnanceId = 2,
                GasExpenseBasePeriod = 11000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 56.08,
                CoxReplacementEquivalent = 0.85,
                IronPerformance = 134.3,
                TheoreticTemperatureBasePeriod = 2091,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 16026.3157894737,
                DeltaIronPerformanceGasChanged = 0,
                DeltaIronPerformanceCoxChanged = -0.002928,
                DeltaTemperatureGasChanged =-0.038
            };
            
            var f4 = new BlastFurnace()
            {
                FurnanceId = 3,
                GasExpenseBasePeriod = 13000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 49.78,
                CoxReplacementEquivalent = 0.59,
                IronPerformance = 122.3,
                TheoreticTemperatureBasePeriod = 1990,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 125,
                DeltaIronPerformanceGasChanged = -0.00072373,
                DeltaIronPerformanceCoxChanged = -0.002897,
                DeltaTemperatureGasChanged = -0.0334
            };
            
            var f5 = new BlastFurnace()
            {
                FurnanceId = 4,
                GasExpenseBasePeriod = 12000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 62.92,
                CoxReplacementEquivalent = 0.75,
                IronPerformance =138.2,
                TheoreticTemperatureBasePeriod = 1997,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 2000,
                DeltaIronPerformanceGasChanged = -0.0007724,
                DeltaIronPerformanceCoxChanged =-0.00297,
                DeltaTemperatureGasChanged = -0.02984
            };
            
            var f6 = new BlastFurnace()
            {
                FurnanceId = 5,
                GasExpenseBasePeriod = 15000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 60.02,
                CoxReplacementEquivalent = 0.79,
                IronPerformance =138.8,
                TheoreticTemperatureBasePeriod = 1925,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 8000,
                DeltaIronPerformanceGasChanged = -0.0006872,
                DeltaIronPerformanceCoxChanged =-0.00297,
                DeltaTemperatureGasChanged = -0.0314
            };
            
            var f7 = new BlastFurnace()
            {
                FurnanceId = 6,
                GasExpenseBasePeriod = 17000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 81.68,
                CoxReplacementEquivalent = 0.87,
                IronPerformance = 191.4,
                TheoreticTemperatureBasePeriod = 1974,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 20000,
                DeltaIronPerformanceGasChanged = -0.0007284,
                DeltaIronPerformanceCoxChanged = -0.003316,
                DeltaTemperatureGasChanged = -0.0223
            };

            var f8 = new BlastFurnace()
            {
                FurnanceId = 7,
                GasExpenseBasePeriod = 14000,
                MinGasExpense = 10000,
                MaxGasExpense = 20000,
                CoxExpenseBasePeriod = 69.7,
                CoxReplacementEquivalent = 0.77,
                IronPerformance = 151.6,
                TheoreticTemperatureBasePeriod = 1982,
                MinTemperature = 1900,
                MaxTemperature = 2100,
                GasExpenseToReadjust = 15000,
                DeltaIronPerformanceGasChanged = -0.0007305,
                DeltaIronPerformanceCoxChanged = -0.00356,
                DeltaTemperatureGasChanged =-0.0244
            };
            return new List<BlastFurnace>()
            {
                f1, f2, f4, f3, f5, f6, f7, f8
            };
        }
        
        private OptimizationModel Solve(OptimizationModel optimizationModel)
        {

            var furnances = optimizationModel.Furnaces;
            SolverContext context = SolverContext.GetContext();
            Model model = context.CreateModel();

            
            var furnancesSet = new Set(Domain.Any, "Furnances");
            
            var parametersList = new List<Parameter>();
            var gasExpenseBasePeriod = new Parameter(Domain.Real, "GasExpenseBasePeriod", furnancesSet);
            gasExpenseBasePeriod.SetBinding(furnances, "GasExpenseBasePeriod", "FurnanceId");
            
            var minGasExpense = new Parameter(Domain.Real, "MinGasExpense", furnancesSet);
            minGasExpense.SetBinding(furnances,"MinGasExpense", "FurnanceId");

            var maxGasExpense = new Parameter(Domain.Real, "MaxGasExpense", furnancesSet);
            maxGasExpense.SetBinding(furnances, "MaxGasExpense", "FurnanceId");

            var coxExpenseBasePeriod = new Parameter(Domain.Real, "CoxExpenseBasePeriod", furnancesSet);
            coxExpenseBasePeriod.SetBinding(furnances, "CoxExpenseBasePeriod", "FurnanceId");

            var coxReplacementEquivalent = new Parameter(Domain.Real, "CoxReplacementEquivalent", furnancesSet);
            coxReplacementEquivalent.SetBinding(furnances, "CoxReplacementEquivalent", "FurnanceId");

            var ironPerformance = new Parameter(Domain.Real, "IronPerformance", furnancesSet);
            ironPerformance.SetBinding(furnances, "IronPerformance", "FurnanceId");

            var theoreticTemperatureBasePeriod = new Parameter(Domain.Real, "TheoreticTemperatureBasePeriod", furnancesSet);
            theoreticTemperatureBasePeriod.SetBinding(furnances, "TheoreticTemperatureBasePeriod", "FurnanceId");
            
            var minTemperature = new Parameter(Domain.Real, "MinTemperature", furnancesSet);
            minTemperature.SetBinding(furnances, "MinTemperature", "FurnanceId");
            
            var maxTemperature = new Parameter(Domain.Real, "MaxTemperature", furnancesSet);
            maxTemperature.SetBinding(furnances, "MaxTemperature", "FurnanceId");

            var deltaIronPerformanceGasChanged = new Parameter(Domain.Real, "DeltaIronPerformanceGasChanged", furnancesSet);
            deltaIronPerformanceGasChanged.SetBinding(furnances, "DeltaIronPerformanceGasChanged", "FurnanceId");

            var deltaIronPerformanceCoxChanged = new Parameter(Domain.Real, "DeltaIronPerformanceCoxChanged", furnancesSet);
            deltaIronPerformanceCoxChanged.SetBinding(furnances, "DeltaIronPerformanceCoxChanged", "FurnanceId");

            var deltaTemperatureGasChanged = new Parameter(Domain.Real, "DeltaTemperatureGasChanged", furnancesSet);
            deltaTemperatureGasChanged.SetBinding(furnances, "DeltaTemperatureGasChanged", "FurnanceId");
            
            parametersList.Add(gasExpenseBasePeriod);
            parametersList.Add(minGasExpense);
            parametersList.Add(maxGasExpense);
            parametersList.Add(coxExpenseBasePeriod);
            parametersList.Add(coxReplacementEquivalent);
            parametersList.Add(ironPerformance);
            parametersList.Add(minTemperature);
            parametersList.Add(maxTemperature);
            parametersList.Add(theoreticTemperatureBasePeriod);
            parametersList.Add(deltaIronPerformanceGasChanged);
            parametersList.Add(deltaIronPerformanceCoxChanged);
            parametersList.Add(deltaTemperatureGasChanged);
            
            model.AddParameters(parametersList.ToArray());
            
            
            Decision decision = new Decision(Domain.RealNonnegative, "decision", furnancesSet);
            model.AddDecision(decision);
            
            /*(koksekv*стоимость кокса - стоимость природного газа)*расход ту readjust*/
            model.AddGoal("CokeSaving", GoalKind.Maximize,
                Model.Sum(Model.ForEach(furnancesSet,  FurnanceId => (coxReplacementEquivalent[FurnanceId] * optimizationModel.CoxCost - optimizationModel.GasCost) * decision[FurnanceId])));

            model.AddConstraint("RequiredIronPerformance",
                Model.Sum(Model.ForEach(furnancesSet, CalculatePerformanceConstraint)) >= optimizationModel.RequiredIronPerformance);
            
            // (расходПГ - расходБазовомПериоде)*ИзмПрЧугИзмПГ - ЭквЗамКокс*(расходПГ - расходБазовомПериоде)*ИзмПрЧугИзимКокса + ПрПоЧугБазовомПер
            Term CalculatePerformanceConstraint(Term FurnanceId)
            {
                var val = (decision[FurnanceId] - gasExpenseBasePeriod[FurnanceId]) * deltaIronPerformanceGasChanged[FurnanceId] -
                          coxReplacementEquivalent[FurnanceId] * (decision[FurnanceId] - gasExpenseBasePeriod[FurnanceId]) *
                          deltaIronPerformanceCoxChanged[FurnanceId] + ironPerformance[FurnanceId];

                return val;
            }
            
            model.AddConstraints("GasExpenseInterval", Model.ForEach(furnancesSet, FurnanceId => (minGasExpense[FurnanceId] <= decision[FurnanceId] <= maxGasExpense[FurnanceId])));

            Term CalculateTemperatureConstraint(Term FurnanceId)
            {
                return (minTemperature[FurnanceId] <= ((decision[FurnanceId] - gasExpenseBasePeriod[FurnanceId]) * deltaTemperatureGasChanged[FurnanceId] + theoreticTemperatureBasePeriod[FurnanceId]) <= maxTemperature[FurnanceId]);
            }
            model.AddConstraints("TemperatureInterval", Model.ForEach(furnancesSet, CalculateTemperatureConstraint));

            Term CalculateCoxSupplyConstraint(Term FurnanceId)
            {
                return coxExpenseBasePeriod[FurnanceId] + 0.001 * (gasExpenseBasePeriod[FurnanceId] - decision[FurnanceId]) + coxReplacementEquivalent[FurnanceId];
            }

            model.AddConstraint("CoxSupply", Model.Sum(Model.ForEach(furnancesSet, CalculateCoxSupplyConstraint)) <= optimizationModel.CoxSupply);

            model.AddConstraint("GasSupply", Model.Sum(Model.ForEach(furnancesSet, FurnanceId => decision[FurnanceId])) <= optimizationModel.GasSupply);

            

            SimplexDirective simplex = new SimplexDirective();
            Solution solved = context.Solve(simplex);
            var report = solved.GetReport();
            optimizationModel.OptimizedFunctionResult = solved.Goals.First().ToDouble();
            var reportToString = report.ToString();
            ViewBag.ReportToString = reportToString;

            var results = report.ToString().Split(new[] {"Decisions:"}, StringSplitOptions.None)[1].Split(':')
                                .Select(line => line.Remove(line.IndexOf("\r", StringComparison.Ordinal)))
                                .Where(line => !string.IsNullOrEmpty(line)).Select(Convert.ToDouble).ToList();

            for (var index = 0; index < furnances.Count; index++)
            {
                var furnace = furnances[index];
                furnace.GasExpenseToReadjust = results[index];
            }

            return optimizationModel;


        }

       
    }
}