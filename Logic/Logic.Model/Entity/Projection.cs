﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using en.AndrewTorski.CineOS.Logic.Model.InterfaceAndBase;

namespace en.AndrewTorski.CineOS.Logic.Model.Entity
{
	/// <summary>
	///		Represents a Projection entity. An event during which a film is shown.
	/// </summary>
	/// <remarks>
	///		This class is associated with a one-to-many relationship with Cinema class, hence
	///		the presence of a reference to a Cinema object in the constructor's parameters.
	///		This is not a composition!!!
	/// </remarks>
	[DataContract]
	public class Projection : AssociatedObject
	{

		/// <summary>
		///		Initializes a new instance of the Projection class using the mandatory refererence
		///		to the Cinema.
		/// </summary>
		/// <param name="cinema">
		///		Reference to the Cinema in which the Projection takes place.
		/// </param>
		public Projection(Cinema cinema)
		{
			throw new NotImplementedException();
		}

		#region Properties
		
		/// <summary>
		///		Unique identifier of the Projection.
		/// </summary>
		[DataMember]
		public int Id { get; set; }

		/// <summary>
		///		Get or sets the date and time of the Projection.
		/// </summary>
		[DataMember]
		public DateTime DateTime { get; set; }

		/// <summary>
		///		Get or sets the duration of the whole projection in minutes.
		/// </summary>
		/// TODO change to film's length
		[DataMember]
		public int Length { get; set; }

		/// <summary>
		///		Gets the Projection Room in which this Projection takes place.
		/// </summary>
		public ProjectionRoom ProjectionRoom
		{
			get
			{
				throw new NotImplementedException();
						
			}
		}

		/// <summary>
		///		Get the Cinema in which this Projection takes place.
		/// </summary>
		public Cinema Cinema
		{
			get { return ProjectionRoom.Cinema; }
		}

		/// <summary>
		///		Return the collection of Mediums associated with this Projection.
		/// </summary>
		public IEnumerable<Medium> Mediums
		{
			get
			{
				throw new NotImplementedException();
			}
		} 

		#endregion

		#region Methods
		
		#endregion

	}
}
