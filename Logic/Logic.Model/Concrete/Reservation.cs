﻿using System;
using System.Collections.Generic;
using System.Linq;
using en.AndrewTorski.CineOS.Logic.Model.Enums;
using en.AndrewTorski.CineOS.Logic.Model.InterfaceAndBase;

namespace en.AndrewTorski.CineOS.Logic.Model.Concrete
{
	public class Reservation : ObjectWithAssociations
	{
		/// <summary>
		///		Date And Time on which this Reservation was made.
		/// </summary>
		private readonly DateTime _dateTime;

		//	TODO TEST THIS THING!
		public Reservation(Client client, Projection projection, IEnumerable<Seat> seats)
		{
			_dateTime = DateTime.Now;
			
			//	Iterate over seats and associate them with this Reservation.
			foreach (var seat in seats)
			{
				AddAssociation(Association.FromReservationToSeat, Association.FromSeatToReservation, seat);
			}

			//	Associate this Reservation with the Client who has made the Reservation.
			AddAssociation(Association.FromReservationToClient, Association.FromClientToReservation, client);

			//	Compose this Reservation into Projection for which this Reservation is made.
			projection.AddReservation(this);
		}
		
		#region Properties

		/// <summary>
		///		Get or sets wheter this reservation redemption status.
		/// </summary>
		public bool IsRedeemed { get; set; }

		/// <summary>
		///		Gets the date and time on which the Reservation was made.
		/// </summary>
		public DateTime DateTime
		{
			get{ return _dateTime; }
		}

		/// <summary>
		///		Gets the Projection for which this Reservation was made.
		/// </summary>
		public Projection Projection
		{
			get { return GetAssociations(Association.FromReservationToProjection).FirstOrDefault() as Projection; }
		}

		/// <summary>
		///		Gets the Client for whom this Reservation was made.
		/// </summary>
		public Client Client
		{
			get { return GetAssociations(Association.FromReservationToClient).FirstOrDefault() as Client; }
		}

		#endregion
	}
}