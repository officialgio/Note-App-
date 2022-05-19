using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Collections.Generic;
using App1.ViewModels;

namespace App1
{
    public class MainPageViewModel : INotifyPropertyChanged
	{
		public MainPageViewModel() // constructor 
		{
			// delete 
			EraseCommand = new Command(() =>
			{
                TheNote = string.Empty;
			});

			// add
			SaveCommand = new Command(() =>
			{
				AllNotes.Add(TheNote); // update list
				TheNote = string.Empty; // reset
			});

            //SelectedNoteChangedCommand = new Command(() =>
            //{
            //	var detailVM = new DetailPageViewModel(TheNote);
            //             var detailPage = new DetailPage();
            //});
        }

		// list to update
		// ObservableCollection allows you to update the UI if updating or removing
		public ObservableCollection<string> AllNotes { get; set; } = new ObservableCollection<string>();

		public event PropertyChangedEventHandler PropertyChanged;

		string theNote; 

		// TheNote property that models theNote
		public string TheNote 
        {
			get => theNote;
			set
            {
				theNote = value;

				// object specifies the name of the property that changed.
				var args = new PropertyChangedEventArgs(nameof(TheNote));

				PropertyChanged?.Invoke(this, args);
            }
        }

		public Command SaveCommand { get; }
        public Command EraseCommand { get; }
		public Command SelectedNoteChangedCommand { get; }


	}
}

