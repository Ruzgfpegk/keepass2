/*
  KeePass Password Safe - The Open-Source Password Manager
  Copyright (C) 2003-2015 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

using KeePassLib.Cryptography.PasswordGenerator;

namespace KeePass.App.Configuration
{
	public sealed class AcePasswordGenerator
	{
		public AcePasswordGenerator()
		{
		}

		private PwProfile m_pwgoAutoProfile = new PwProfile();
		public PwProfile AutoGeneratedPasswordsProfile
		{
			get { return m_pwgoAutoProfile; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_pwgoAutoProfile = value;
			}
		}

		private PwProfile m_pwgoLastProfile = new PwProfile();
		public PwProfile LastUsedProfile
		{
			get { return m_pwgoLastProfile; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_pwgoLastProfile = value;
			}
		}

		private List<PwProfile> m_vUserProfiles = new List<PwProfile>();
		[XmlArrayItem("Profile")]
		public List<PwProfile> UserProfiles
		{
			get { return m_vUserProfiles; }
			set
			{
				if(value == null) throw new ArgumentNullException("value");
				m_vUserProfiles = value;
			}
		}
	}
}
