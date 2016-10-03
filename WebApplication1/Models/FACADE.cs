using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FACADE
    {

        static void crud() {


            //Adding Industries
            leVillageEntities lve = new leVillageEntities();
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
            campus.parentCampus = 1;
            campus.idCountry=1;
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

            if (campusesName != null) {

                campusesName.campusName = "";
                lve.SaveChanges();

            }




            //delete
            var campusesNameDel = lve.Campus.Where(x => x.campusName == "Delmas").FirstOrDefault();
            lve.Campus.Remove(campusesName);
            lve.SaveChanges();


        }


        public void addPerson() {

            leVillageEntities lve = new leVillageEntities();
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
            person.personalTestimony = "Personnal Testimony";
            person.personalTestimonyDoc = new Byte();
            person.Address = new Address() { street = "streetName", city="CityName", state="Departement", postalCode="HT6120", idCountry=1 };
            person.isMember = 0;
            person.dateMembership = new DateTime(); //if the person is not a member, don't put any date
            person.EntryPoint = new EntryPoint() { entryPointName = "Service", locationEntryPoint = "La Gonave" };
            person.dateWedding = new DateTime(); // if the person is not married, don't put any date
            person.FamilyRole = new FamilyRole() { familyRoleName = "Father", familyRoleCode="FATHER" };
            person.Family = new Family() { FamilyName= person.lastName, idAddress= person.Address.idAddress };
            person.isDeceased = 0; // when entering the person, the person should not be deceased, if deceased give another interface
            person.Campu = new Campu() { campusName = "", campusStreet = "", campusCity = "", campusPostalCode = "", parentCampus = 1, idCountry = 1};
            person.MedicalInfo = new MedicalInfo() { DoctorName = "", DoctorPhone = "", DoctorEmail= "", idbloodType = 1, height = "5.6", allergies = "", pathologies="", medicines= "", vaccines="", comments="" };
            lve.People.Add(person);
            lve.SaveChanges();
        }


        public String generateMemberIdentificationNumber() {


            return "";
        }

        public void addPersonStatusHistory(Person person)
        {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                StatusHistory statusHistory = new StatusHistory();
                statusHistory.startDate = new DateTime();
                statusHistory.endDate = new DateTime();
                statusHistory.effectiveDate = new DateTime();
                statusHistory.statusAtChurch = 1;                    //new CheckListCategory() { idcheckListCategory = 1, namecheckListCategory = "Papa", isMemberStatus = 1 };
                statusHistory.Person = person;

                lve.SaveChanges();

            }
        }


        public void addPersonEmployementHistory(Person person) {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                EmploymentHistory employmentHistory = new EmploymentHistory();
                employmentHistory.EmployerName = "MerQury";
                employmentHistory.fromDate = new DateTime();
                employmentHistory.toDate = new DateTime();
                employmentHistory.position = "CEO";
                employmentHistory.Person = person;
                lve.SaveChanges();

            }
            }



        public void addPersonStudyLevel(Person person) {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                StudyLevel studyLevel = new StudyLevel();
                studyLevel.StudyLevelType = new StudyLevelType() { idStudyLevelType=1, nameStudyLevelType = "School" };
                studyLevel.nameSchoolOrUniversity = "";
                studyLevel.fromDate = new DateTime();
                studyLevel.toDate = new DateTime();
                studyLevel.Person = person;
                lve.SaveChanges();
            }

        }


        public void addPersonMaritalStatus(Person person) {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                MaritalStatu maritalstatus = new MaritalStatu();
                maritalstatus.MaritalStatusType = new MaritalStatusType() { idMaritalStatusType=1, nameMaritalStatusType="Married" };
                maritalstatus.startDate = new DateTime();
                maritalstatus.endDate = new DateTime();
                maritalstatus.Person = person;
                lve.SaveChanges();
            }
        }


        public void addPersonPhotos(Person person) {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {
                PersonPhoto personPhoto = new PersonPhoto();
                personPhoto.photoPaths = "";
                personPhoto.PhotoBLOB = new Byte();
                personPhoto.Person = person;
                lve.SaveChanges();
            }

        }

        public void addPersonDocuments(Person person) {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                lve.SaveChanges();
            }


        }


        public void addPersonChurchHistory(Person person) {

            leVillageEntities lve = new leVillageEntities();

            var people = lve.People.Where(x => x.memberIdentificationNumber == "Delmas").FirstOrDefault();

            if (people != null)
            {

                ChurchHistory churchHistory = new ChurchHistory();
                churchHistory.churchName = "Eglise Calvary";
                churchHistory.pastorName = "Frank Leroy";
                churchHistory.roleInChurch = 1;
                churchHistory.comments = "";
                churchHistory.Person = person;
                lve.SaveChanges();
            }

        }


        public void searchPerson() {




        }


        public void updatePerson() {

        }


        public void removePerson()
        {


        }




    }
}