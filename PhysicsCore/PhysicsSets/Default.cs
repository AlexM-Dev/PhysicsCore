using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhysicsCore {
    public class Default : PhysicsSet {
        public string UUID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Default() {
            UUID = Guid.NewGuid().ToString();
            Name = "Default Physics";
            Description = "The default physics for Dots.";
        }
        public virtual void ApplyPhysics(Dot d1, Dot d2, Config cfg) {
            if (d1 == null || d2 == null) { return; }
            int moveX = 0; int moveY = 0;
            if (d2.p.X < d1.p.X) {
                moveX = cfg.MoveValue;
            } else if (d2.p.X > d1.p.X) {
                moveX = -1 * cfg.MoveValue;
            }


            if (d2.p.Y < d1.p.Y) {
                moveY = cfg.MoveValue;
            } else if (d2.p.Y > d1.p.Y) {
                moveY = -1 * cfg.MoveValue;
            }
            d1.p = new Point(d1.p.X + moveX, d1.p.Y + moveY);
        }
        public Dot GetDot(Dot d1, Config cfg) {
            return cfg.Particles[cfg.r.Next(cfg.Particles.Count - 1)];
        }
    }
}
