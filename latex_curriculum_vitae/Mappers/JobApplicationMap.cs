﻿// Copyright (C) 2020 Sascha Manns <Sascha.Manns@outlook.de>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

// Dependencies

using CsvHelper.Configuration;
using latex_curriculum_vitae.Models;

namespace latex_curriculum_vitae.Mappers
{
    public sealed class JobApplicationMap : ClassMap<JobApplicationModel>
    {
        public JobApplicationMap()
        {
            Map(m => m.Company).Name(Constants.CsvHeaders.Company);
            Map(m => m.Jobtitle).Name(Constants.CsvHeaders.Jobtitle);
            Map(m => m.City).Name(Constants.CsvHeaders.City);
            Map(m => m.Status).Name(Constants.CsvHeaders.Status);
            Map(m => m.EmailSent).Name(Constants.CsvHeaders.EmailSent);
            Map(m => m.JobOfferUrl).Name(Constants.CsvHeaders.JobOfferUrl);
        }
    }
}
