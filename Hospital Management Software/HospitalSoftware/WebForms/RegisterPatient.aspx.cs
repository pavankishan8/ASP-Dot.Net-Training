using HospitalSoftware.Models;
using HospitalSoftware.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSoftware.WebForms
{
    public partial class RegisterPatient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Helpers.PopulateDoctors(dpDoctors, Application["Doctors"]);
            }
        }

       

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            var repo = Application["Patients"] as PatientRepo;
            var patient = new Patient
            {
                DateOfBirth = DateTime.Parse(txtDob.Text),
                DoctorId = int.Parse(dpDoctors.SelectedValue),
                PatientName = txtName.Text,
                PatientMobile = long.Parse(txtMobile.Text)
            };

            repo.RegisterNewPatient(patient);
            Application["Patients"] = repo;
            lblMessage.Text = "Patient Registered Successfully";
        }
    }
}