using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FacebookWrapper.ObjectModel.User m_LoggedInUser;

        private void btLogin_Click(object sender, EventArgs e)
        {
            FacebookWrapper.LoginResult result =
            FacebookWrapper.FacebookService.Login("447860082058010", "user_photos", "user_friends", "user_events", "user_status", "publish_actions");
            FacebookWrapper.FacebookService.Login("447860082058010", "user_photos", "user_friends", "user_events", "user_status", "publish_actions");
            FacebookWrapper.FacebookService.Login("447860082058010", "user_photos", "user_friends", "user_events", "user_status", "publish_actions");

            if (string.IsNullOrEmpty(result.ErrorMessage))
            {
                m_LoggedInUser = result.LoggedInUser;
                pictureBoxProfile.Load(m_LoggedInUser.PictureNormalURL);
                bt_Login.Text = m_LoggedInUser.FirstName + " " + m_LoggedInUser.LastName;
       
            }
        }

        private void btFetchAlbum_Click(object sender, EventArgs e)
        {
            foreach (FacebookWrapper.ObjectModel.Album album in m_LoggedInUser.Albums)
            {
              
                listBoxAlbum.Items.Add(album.Name);
            }
        }

        private void btFetchCheckins_Click(object sender, EventArgs e)
        {

            foreach (FacebookWrapper.ObjectModel.Status chekin in m_LoggedInUser.Statuses)
            {

                listBoxCheckIns.Items.Add(chekin.Place.Location.City);
            }
            
        }

        private void btFetchFriends_Click(object sender, EventArgs e)
        {
            
        }

        private void btFetchEvents_Click(object sender, EventArgs e)
        {

            foreach (FacebookWrapper.ObjectModel.Event eventt in m_LoggedInUser.Events)
            {

                listBoxEvents.Items.Add(eventt.Name);
            }
        }
        private void btPost_Click(object sender, EventArgs e)
        {
      
            m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus("alex gay! alex gay! alex gay! alex gay! alex gay! alex gay! alex gay!!!!");
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
			m_LoggedInUser.PostStatus(textBox1.Text);
        }

    }
}
