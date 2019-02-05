using System;

namespace Geodex
{
    interface IKopernicusStar
    {
        public static void SunBodyFlux(ModularFlightIntegrator flightIntegrator);
        public static void CalculatePhysics();
        public static double Flux();
        public static IKopernicusStar GetNearest();
        protected override void Awake();
        protected override void Start();
        void SceneLoaded();
        void LateUpdate();
        public override double GetLocalTimeAtPosition(Vector3d wPos, CelestialBody cb);
    }
}
