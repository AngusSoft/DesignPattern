using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    /// <summary>
    /// 首先创建发起人角色
    /// </summary>
    public class Originator
    {
        private Student _student;
        public Originator(Student student)
        {
            _student = student;
        }

        /// <summary>
        /// 备份一个对象
        /// </summary>
        /// <returns></returns>
        public Student CreateStudent()
        {
            Student student = new Student();
            student.Id = _student.Id;
            student.Name = _student.Name;
            return student;
        }

        /// <summary>
        /// 移除对象
        /// </summary>
        public void RemoveStudent()
        {
            _student = null;
        }

        /// <summary>
        /// 还原对象
        /// </summary>
        /// <param name="student"></param>
        public void RestoreStudent(Student student)
        {
            _student = new Student
            {
                Id = student.Id,
                Name = student.Name
            };
        }

        /// <summary>
        /// 获取对象
        /// </summary>
        public string GetStudentName()
        {
            return string.IsNullOrEmpty(_student?.Name) ? "我被删除了" : _student.Name;
        }
    }
}
