using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace App1.ViewModels
{
	public class DetailPageViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public DetailPageViewModel(string note)
		{
			this.noteText = note;
		}


		string noteText;

		//public string NoteText
  //      {
		//	get => noteText;
		//	set
  //          {
		//		noteText = value;
		//		var args = new PropertyChangingEventArgs(nameof(NoteText));

		//		PropertyChanged?.Invoke(this, args);
  //          }
  //      }

		public Command DismissPageCommand { get; }
	}
}

