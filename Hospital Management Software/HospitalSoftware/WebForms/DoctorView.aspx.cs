using HospitalSoftware.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalSoftware.WebForms
{
    public partial class DoctorView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Helpers.PopulateDoctors(dpDoctors, Application["Doctors"]);
        }

        protected void dpDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = int.Parse(dpDoctors.SelectedValue);
            var patientRepo = Application["Patients"] as PatientRepo;
            var patients = patientRepo.GetPatients(id);
            lstPatients.DataSource = patients;
            lstPatients.DataTextField = "PatientName";
            lstPatients.DataValueField = "PatientId";
            lstPatients.DataBind();
        }

        protected void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(lstPatients.SelectedValue);
            var repo = Application["Patients"] as PatientRepo;
            var selected = repo.FindPatient(id);
            txtId.Text = selected.PatientId.ToString();
            txtName.Text = selected.PatientName;
            txtAge.Text = selected.Age.ToString();
            txtMobile.Text = selected.PatientMobile.ToString();
        }
    }
}