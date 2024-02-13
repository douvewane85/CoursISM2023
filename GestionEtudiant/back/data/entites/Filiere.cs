﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.entites
{
    public class Filiere
    {
        private int id;
        private string name;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public Filiere() { }

        public Filiere(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
