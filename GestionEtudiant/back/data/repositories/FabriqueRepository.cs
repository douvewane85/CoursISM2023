using GestionEtudiant.back.core.impl;
using GestionEtudiant.back.data.enums;
using GestionEtudiant.back.data.repositories.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEtudiant.back.data.repositories
{
    public  class FabriqueRepository
    {

       private FabriqueRepository() { 
        }

        public static DataBase   GetInstance(RepositoryName repositoryName)
        {
            switch (repositoryName)
            {
                case RepositoryName.UserRepository:
                    return UserRepository.GetInstance();
                    break;
                case RepositoryName.ClasseRepository:
                    return ClasseRepository.GetInstance();
                    break;
                default:
                    return UserRepository.GetInstance();
                    break;
            }
           
        }
       
    }
}
