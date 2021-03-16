using DoanBuiQuangVinh_5951071122.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoanBuiQuangVinh_5951071122.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfoList = new List<StudentInfo>();
            for(int i=0; i<10;i++)
            {
                var StudentInfo = new StudentInfo
                {
                    MaSV = $"5951071122",
                    TenSV = $"Đoàn Bùi Quang Vĩnh",
                    Namsinh = i,
                    Tuoi = DateTime.Now.Year - i
                };
                studentInfoList.Add(StudentInfo);
            }    
            
            return studentInfoList;
        }



        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {

                MaSV = $"5951071122",
                TenSV = $"Đoàn Bùi Quang Vĩnh",
                Namsinh = id,
                Tuoi = DateTime.Now.Year - id

            };
        }
       

        
    }
}
