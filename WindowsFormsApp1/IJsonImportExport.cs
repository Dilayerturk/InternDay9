﻿using System.ComponentModel;

namespace WindowsFormsApp1
{
    public interface IJsonImportExport
    {
        string FileExtension { get; }
        string Name { get; }

        BindingList<Person> Open(string filePath);
        void Save(string filePath, BindingList<Person> personList);
    }
}