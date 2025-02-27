﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Information_System.Models;
using Student_Information_System.Repositories;
using Student_Information_System.Repositories;

namespace Student_Information_System.Exceptions
{
    internal class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string message) : base(message)
        {

        }

        public static void StudentNotFound(int studentId)
        {
            StudentRepository studentRepository = new StudentRepository();
            if (!studentRepository.StudentExists(studentId))
                throw new StudentNotFoundException("Student not found!!!");
        }
    }
}
