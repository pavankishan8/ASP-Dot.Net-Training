using System;
using System.Linq;
using System.Collections.Generic;
using HospitalSoftware.Interfaces;
using HospitalSoftware.Models;

namespace HospitalSoftware.Services
{
    public class DoctorRepo
    {
        public List<Doctor> AllDoctors => new List<Doctor>
        {
            new Doctor{
                DoctorId = 1, DoctorName = "Nagraj", Fees = 2500, Specialization="Cardiology" },
            new Doctor{
                DoctorId = 2, DoctorName = "Dinesh", Fees = 1500, Specialization="Dental Specialist" },
            new Doctor{
                DoctorId = 3, DoctorName = "Rithu", Fees = 3500, Specialization="Peditrician" },
        };
    }

    public class PatientRepo : IPatientRepo
    {
        private List<Patient> patients = new List<Patient>();
        public PatientRepo()
        {

        }
        public PatientRepo(List<Patient> oldRecords)
        {
            patients = oldRecords;
        }

        public Patient FindPatient(int patientId) => patients.Find((p) => p.PatientId == patientId);
        public List<Patient> GetPatients(int docId) => patients.FindAll((p) => p.DoctorId == docId);

        public void RegisterNewPatient(Patient patient)
        {
            var id = 1;
            if (patients.Count != 0)
            {
                var lastId = patients[patients.Count - 1].PatientId;
                id = ++lastId;
            }
            patient.PatientId = id;
            patients.Add(patient);
        }

        public void UpdatePatient(Patient patient)
        {
            var selected = FindPatient(patient.PatientId);
            if (selected == null)
                throw new Exception("Patient Details not found");
            selected.PatientMobile = patient.PatientMobile;
            selected.PatientName = patient.PatientName;
            selected.DateOfBirth = patient.DateOfBirth;
            selected.DoctorId = patient.DoctorId;
        }
    }

    public class BillingRepo
    {
        private List<Billing> bills;
        public BillingRepo(List<Billing> oldRecords)
        {
            bills = oldRecords;
        }

        public void AddBill(Patient patientInfo)
        {
            int billNo = bills.LastOrDefault().BillNo;
            Billing billing = new Billing();
            billing.BillNo = ++billNo;
            billing.PatientId = patientInfo.PatientId;
            billing.BillAmount = getFees(patientInfo.DoctorId);
            bills.Add(billing);
        }

        public List<Billing> AllBills => bills;
        private int getFees(int docId)
        {
            var docRepo = new DoctorRepo();
            var doc = docRepo.AllDoctors.Find((d) => d.DoctorId == docId);
            return doc.Fees;
        }
    }
}