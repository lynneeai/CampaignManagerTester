﻿using System.Runtime.Serialization;

namespace ConsoleApplication1
{

	public class CampaignSignUpJSON
	{

		public CampaignSignUpJSON(string Slug)
		{
            this.slug = Slug;
            this.fields = new object[3];
            string name = "email";
            fields[0] = name;
            string description = "Email";
            fields[1] = description;
            string type = "email";
            fields[2] = type;
		}

		public string slug;
		public object[] fields;


		public override string ToString()
		{
			return "";
		}
	}

	public class CampaignSignUpFieldsJSON
	{
		public CampaignSignUpFieldsJSON(string Key, string Val)
		{
			this.key = Key;
			this.value = Val;
		}

		public string key;
		public string value;

		public override string ToString ()
		{
			return "";
		}
	}

	public class SignUpJSON
	{
		public SignUpJSON(string Email, string Slug)
		{
			this.email = Email;
			this.slug = Slug;
		}

		public string email;
		public string slug;
	}

}



