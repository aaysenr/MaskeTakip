using Business.Abstract;
using Entities.Concrete;
using MermisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //cıplak class kalmasın
    public  class PersonManager : IApplicantService
    {
        //encapsulation 
        // person bilgilerini parametre olarak değil person sınıfı içinde tutuldu
        public void ApplyForMask(Person person)
        { 
            
        }

        public List <Person> GetList()
        {

            return null;


        }


        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest 
                (new TCKimlikNoDogrulaRequestBody (person.NationalIdentity,person.FirstName,person.LastName,person.DateofBirthYear)))
                 .Result.Body.TCKimlikNoDogrulaResult;


        }

    }
}
