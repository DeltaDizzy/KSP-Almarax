using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace AzraqamaAerospace
{
    public class ModuleStockDisphotovoltaicPanel : ModuleDeployableSolarPanel
    {
        ModuleResourceHandler hand;
        public double currentFlux;

        public override void OnStart(StartState state)
        {

            //find sun
            CelestialBody sun = FlightIntegrator.sunBody;
        }

        void Update()
        {
            if (FlightGlobals.ActiveVessel.directSunlight)
            {
                currentFlux = FlightIntegrator.ActiveVesselFI.solarFlux *= FlightIntegrator.ActiveVesselFI.solarFluxMultiplier;
                hand.UpdateModuleResourceOutputs();
            }
        }
    }
}
