using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FACADE
    {
        private leVillageEntities1 lve;

        public FACADE(leVillageEntities1 _lve) {
            lve = _lve;
        }

        public void crud()
        {


            //Adding Industries
            
            Industry industry = new Industry();
            industry.industryName = "";
            lve.Industries.Add(industry);
            lve.SaveChanges();

            //Adding EntryPoint
            EntryPoint entrypoint = new EntryPoint();
            entrypoint.entryPointName = "";
            entrypoint.locationEntryPoint = "";
            lve.EntryPoints.Add(entrypoint);
            lve.SaveChanges();

            //adding marital statusType
            MaritalStatusType mst = new MaritalStatusType();
            mst.nameMaritalStatusType = "";
            lve.MaritalStatusTypes.Add(mst);
            lve.SaveChanges();



            //adding StudyLevelType

            StudyLevelType slt = new StudyLevelType();
            slt.nameStudyLevelType = "";
            lve.StudyLevelTypes.Add(slt);
            lve.SaveChanges();


            //adding ChecklistCategory

            CheckListCategory cListCategory = new CheckListCategory();
            cListCategory.namecheckListCategory = "";
            cListCategory.isMemberStatus = 1;
            lve.CheckListCategories.Add(cListCategory);
            lve.SaveChanges();


            //Campus

            Campu campus = new Campu();
            campus.campusName = "";
            campus.campusStreet = "";
            campus.campusCity = "";
            campus.campusPostalCode = "";
            campus.idCountry = 1;
            lve.Campus.Add(campus);
            lve.SaveChanges();

            //Listing

            var industries = lve.Industries.ToList();
            foreach (var item in industries)
            {

                Console.WriteLine(item);
            }

            var campusesLocation = lve.Campus.Where(x => x.campusCity == "Delmas").ToList();


            //Update 
            //prevent concurrency

            var campusesName = lve.Campus.Where(x => x.campusName == "Delmas").FirstOrDefault();

            if (campusesName != null)
            {

                campusesName.campusName = "";
                lve.SaveChanges();

            }




            //delete
            var campusesNameDel = lve.Campus.Where(x => x.campusName == "Delmas").FirstOrDefault();
            lve.Campus.Remove(campusesName);
            lve.SaveChanges();


        }

        public void addPerson()
        {

            
            Person person = new Person();
            person.firstName = "Paul";
            person.lastName = "Murphy";
            person.memberIdentificationNumber = generateMemberIdentificationNumber();
            person.dateOfBirth = new DateTime();
            person.sex = "Male";
            person.email = "pmurphy@merqury.com";
            person.phone = "+50937416899";
            person.isConverted = 0;
            person.dateConversion = new DateTime(); // if the person is not converted, don't put any date
            person.isBaptized = 0;
            person.dateBaptism = new DateTime(); //if the person is not baptized, don't put any date
            person.Profession = new Profession() { professionName = "Financial Engineer", idIndustry = 1 };
            person.Address = new Address() { street = "streetName", city = "CityName", state = "Departement", postalCode = "HT6120", idCountry = 1 };
            person.isMember = 0;
            person.dateMembership = new DateTime(); //if the person is not a member, don't put any date
            person.EntryPoint = new EntryPoint() { entryPointName = "Service", locationEntryPoint = "La Gonave" };
            person.dateWedding = new DateTime(); // if the person is not married, don't put any date
            person.FamilyRole = new FamilyRole() { familyRoleName = "Father", familyRoleCode = "FATHER" };
            person.Family = new Family() { FamilyName = person.lastName, idAddress = person.Address.idAddress };
            person.isDeceased = 0; // when entering the person, the person should not be deceased, if deceased give another interface
            person.Campu = new Campu() { campusName = "", campusStreet = "", campusCity = "", campusPostalCode = "", idCountry = 1 };
            person.MedicalInfo = new MedicalInfo() { doctorName = "", doctorPhone = "", doctorEmail = "", idbloodType = 1, height = "5.6", allergies = "", pathologies = "", medicines = "", vaccines = "", comments = "" };
            lve.People.Add(person);
            lve.SaveChanges();
        }

        public String generateMemberIdentificationNumber()
        {

            return "";
        }

        public int? lastAccessCountDocument()
        {


            int? count;

            

            var document = lve.Documents.Where(x => x.documentsName == "Delmas").FirstOrDefault();

            count = document.accessCount;
            return count;

        }

        public void addPersonStatusHistory(Person person)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                StatusHistory statusHistory = new StatusHistory();
                statusHistory.startDate = new DateTime();
                statusHistory.endDate = new DateTime();
                statusHistory.effectiveDate = new DateTime();
                statusHistory.statusAtChurch = 1;                    //new CheckListCategory() { idcheckListCategory = 1, namecheckListCategory = "Papa", isMemberStatus = 1 };
                statusHistory.Person = person;
                lve.StatusHistories.Add(statusHistory);
                lve.SaveChanges();

            }
        }

        public void addPersonEmployementHistory(Person person)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                EmploymentHistory employmentHistory = new EmploymentHistory();
                employmentHistory.EmployerName = "MerQury";
                employmentHistory.fromDate = new DateTime();
                employmentHistory.toDate = new DateTime();
                employmentHistory.position = "CEO";
                employmentHistory.Person = person;
                lve.EmploymentHistories.Add(employmentHistory);
                lve.SaveChanges();

            }
        }

        public void addPersonStudyLevel(Person person)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                StudyLevel studyLevel = new StudyLevel();
                studyLevel.StudyLevelType = new StudyLevelType() { idStudyLevelType = 1, nameStudyLevelType = "School" };
                studyLevel.nameSchoolOrUniversity = "";
                studyLevel.fromDate = new DateTime();
                studyLevel.toDate = new DateTime();
                studyLevel.Person = person;
                lve.StudyLevels.Add(studyLevel);
                lve.SaveChanges();
            }

        }

        public void addPersonMaritalStatus(Person person)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                MaritalStatu maritalstatus = new MaritalStatu();
                maritalstatus.MaritalStatusType = new MaritalStatusType() { idMaritalStatusType = 1, nameMaritalStatusType = "Married" };
                maritalstatus.startDate = new DateTime();
                maritalstatus.endDate = new DateTime();
                maritalstatus.Person = person;
                lve.MaritalStatus.Add(maritalstatus);
                lve.SaveChanges();
            }
        }

        public void addPersonAddresses(Person person)
        {

            

            Address address = new Address();
            address.street = "";
            address.city = "";
            address.state = "";
            address.postalCode = "";
            address.idCountry = 1;
            address.People.Add(person);
            lve.Addresses.Add(address);
            lve.SaveChanges();

        }

        public void addPersonToFamily(Person person)
        {

            

            Family family = new Family();
            family.FamilyName = person.lastName;
            family.Address = person.Address;
            family.phone = person.phone;
            family.picture = new byte[] { 0x00, 0x00, 0x00, 0x00 };
            lve.Families.Add(family);
            lve.SaveChanges();

        }

        public void addPersonPhotos(Person person)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                PersonPhoto personPhoto = new PersonPhoto();
                personPhoto.photoPaths = "";
                personPhoto.PhotoBLOB = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                personPhoto.Person = person;
                lve.PersonPhotos.Add(personPhoto);
                person.PersonPhotos.Add(personPhoto);
                lve.SaveChanges();
            }

        }

        public void addPersonDocuments(Person person)
        {

            

            Document document = new Document();
            document.documentsName = "";
            document.documentsDetails = "";
            document.documentsPath = "";
            document.accessCount = 1;
            document.dateUploaded = new DateTime();
            document.uploadedBy = "";
            document.DocumentType = new DocumentType() { idDocumentType = 1, documentTypeName = "" };
            lve.Documents.Add(document);
            person.Documents.Add(document);
            lve.SaveChanges();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                
            }


        }

        public void addPersonTithes(Person person)
        {

            

            Tithe tithes = new Tithe();
            tithes.idTithes = 1;
            tithes.titheDate = new DateTime();
            tithes.titheAmount = (decimal) 9.4;
            tithes.titheComment = "";
            tithes.Currency = new Currency() { idCurrency = 1, currencyName = "", currencyCode = "", currencyImage = new byte[] { 0x00, 0x00, 0x00, 0x00 } };
            tithes.Person = person;
            lve.Tithes.Add(tithes);
            lve.SaveChanges();

        }

        public void addPersonNotes(Person person)
        {

            

            Note notes = new Note();

            notes.idNotes = 1;
            notes.notesDescription = "";
            notes.createdDate = new DateTime();
            notes.modifiedDate = new DateTime();
            notes.createdBy = "";
            notes.modifiedBy = "";
            notes.idNoteType = 1;


            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                notes.Person = person;
                lve.Notes.Add(notes);
                lve.SaveChanges();
            }


        }

        public void addPersonChurchHistory(Person person)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                ChurchHistory churchHistory = new ChurchHistory();
                churchHistory.churchName = "Eglise Calvary";
                churchHistory.pastorName = "Frank Leroy";
                churchHistory.roleInChurch = 1;
                churchHistory.comments = "";
                churchHistory.Person = person;
                lve.ChurchHistories.Add(churchHistory);
                lve.SaveChanges();
            }

        }

        public Person searchPersonByIdentificationNumber(String identificationNumber)
        {

            

            var people = lve.People.Where(x => x.memberIdentificationNumber == identificationNumber).FirstOrDefault();

            if (people != null)
            {


            }

            return people;
        }


        public List<Person> searchPersonByName(String name)
        {

            

            var people = lve.People.Where(x => x.firstName == name || x.lastName == name || x.phone == name || x.memberIdentificationNumber == name).ToList();

            if (people != null)
            {


            }

            return people;
        }

        public void updatePerson(int? id, Person person)
        {


            

            var people = lve.People.Where(x => x.idPerson == id).FirstOrDefault();



            person.firstName = "Paul";
            person.lastName = "Murphy";
            person.memberIdentificationNumber = generateMemberIdentificationNumber();
            person.dateOfBirth = new DateTime();
            person.sex = "Male";
            person.email = "pmurphy@merqury.com";
            person.phone = "+50937416899";
            person.isConverted = 0;
            person.dateConversion = new DateTime(); // if the person is not converted, don't put any date
            person.isBaptized = 0;
            person.dateBaptism = new DateTime(); //if the person is not baptized, don't put any date
            person.Profession = new Profession() { professionName = "Financial Engineer", idIndustry = 1 };
            person.Address = new Address() { street = "streetName", city = "CityName", state = "Departement", postalCode = "HT6120", idCountry = 1 };
            person.isMember = 0;
            person.dateMembership = new DateTime(); //if the person is not a member, don't put any date
            person.EntryPoint = new EntryPoint() { entryPointName = "Service", locationEntryPoint = "La Gonave" };
            person.dateWedding = new DateTime(); // if the person is not married, don't put any date
            person.FamilyRole = new FamilyRole() { familyRoleName = "Father", familyRoleCode = "FATHER" };
            person.Family = new Family() { FamilyName = person.lastName, idAddress = person.Address.idAddress };
            person.isDeceased = 0; // when entering the person, the person should not be deceased, if deceased give another interface
            person.Campu = new Campu() { campusName = "", campusStreet = "", campusCity = "", campusPostalCode = "", idCountry = 1 };
            person.MedicalInfo = new MedicalInfo() { doctorName = "", doctorPhone = "", doctorEmail = "", idbloodType = 1, height = "5.6", allergies = "", pathologies = "", medicines = "", vaccines = "", comments = "" };
            lve.SaveChanges();
        }

        public void updatePerson(Person person)
        {


            

            person.firstName = "Paul";
            person.lastName = "Murphy";
            person.memberIdentificationNumber = generateMemberIdentificationNumber();
            person.dateOfBirth = new DateTime();
            person.sex = "Male";
            person.email = "pmurphy@merqury.com";
            person.phone = "+50937416899";
            person.isConverted = 0;
            person.dateConversion = new DateTime(); // if the person is not converted, don't put any date
            person.isBaptized = 0;
            person.dateBaptism = new DateTime(); //if the person is not baptized, don't put any date
            person.Profession = new Profession() { professionName = "Financial Engineer", idIndustry = 1 };
            person.Address = new Address() { street = "streetName", city = "CityName", state = "Departement", postalCode = "HT6120", idCountry = 1 };
            person.isMember = 0;
            person.dateMembership = new DateTime(); //if the person is not a member, don't put any date
            person.EntryPoint = new EntryPoint() { entryPointName = "Service", locationEntryPoint = "La Gonave" };
            person.dateWedding = new DateTime(); // if the person is not married, don't put any date
            person.FamilyRole = new FamilyRole() { familyRoleName = "Father", familyRoleCode = "FATHER" };
            person.Family = new Family() { FamilyName = person.lastName, idAddress = person.Address.idAddress };
            person.isDeceased = 0; // when entering the person, the person should not be deceased, if deceased give another interface
            person.Campu = new Campu() { campusName = "", campusStreet = "", campusCity = "", campusPostalCode = "", idCountry = 1 };
            person.MedicalInfo = new MedicalInfo() { doctorName = "", doctorPhone = "", doctorEmail = "", idbloodType = 1, height = "5.6", allergies = "", pathologies = "", medicines = "", vaccines = "", comments = "" };
            lve.SaveChanges();
        }

        public void removePerson(int id)
        {

            

            var people = lve.People.Where(x => x.idPerson == id).FirstOrDefault();

            var churchHistory = lve.ChurchHistories.Where(x => x.idPerson == id).FirstOrDefault();
            var notes = lve.Notes.Where(x => x.idPerson == id).FirstOrDefault();
            var tithes = lve.Tithes.Where(x => x.idPerson == id).FirstOrDefault();
            var photos = lve.PersonPhotos.Where(x => x.idPerson == id).FirstOrDefault();
            var maritalStatus = lve.MaritalStatus.Where(x => x.idPerson == id).FirstOrDefault();
            var studyLevel = lve.StudyLevels.Where(x => x.idPerson == id).FirstOrDefault();
            var employmentHistory = lve.EmploymentHistories.Where(x => x.idPerson == id).FirstOrDefault();
            var statusHistory = lve.StatusHistories.Where(x => x.idPerson == id).FirstOrDefault();
            var documents = lve.Documents.Where(x => x.idPerson == id).FirstOrDefault();

            //test if addresses and family belongs to someoneelse 

            //var address = lve.Addresses.Where(x => x.idPerson == id).FirstOrDefault();
            //var address = lve.Families.Where(x => x.idPerson == id).FirstOrDefault();

            people.ChurchHistories.Remove(churchHistory);
            people.Notes.Remove(notes);
            people.Tithes.Remove(tithes);
            people.PersonPhotos.Remove(photos);
            people.MaritalStatus.Remove(maritalStatus);
            people.StudyLevels.Remove(studyLevel);
            people.EmploymentHistories.Remove(employmentHistory);
            people.StatusHistories.Remove(statusHistory);
            people.Documents.Remove(documents);
            //  people.Addresses.Remove(churchHistory);
            //  people.Families.Remove(churchHistory);

        }


        public List<Person> getAllPerson()
        {
            return lve.People
            .OrderBy(p=> p.memberIdentificationNumber)
            .ToList();

        }

        public List<Person> getAllPersonWithData() {

            return lve.People
            .OrderBy(p => p.memberIdentificationNumber)
            .ToList();

        }

    }
}