using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhysicsCore {
    public class Config {
        public int MoveValue = 0;
        public bool DrawStats = false;
        public int SpawnAmount = 0;
        public int SpawnSize = 2;
        public Color ParticleColor = Color.FromArgb(82, 82, 82);
        public Random r = new Random();
        public List<Dot> Particles = new List<Dot>();
    }
}
