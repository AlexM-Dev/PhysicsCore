using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysicsCore {
    public interface PhysicsSet {
        string Name { get; set; }
        string Description { get; set; }
        void ApplyPhysics(Dot d1, Dot d2, Config cfg);
        Dot GetDot(Dot d1, Config cfg);
    } //             return cfg.Particles[cfg.r.Next(cfg.Particles.Count - 1)];
}
