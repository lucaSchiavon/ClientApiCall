
using it.itryframework2.attributes;
using System;

namespace it.aquest.classes
{
	public class Utente : it.itryframework2.interfaces.IGenericObject
	{
		public Utente()
		{
		}

        ///<summary>
        ///Ottiene o imposta la proprietà Email.
        ///</summary>
        private string m_Email;
		[DBAttributes(DbColumnName= "Email")]
		public string Email
        {
			get { return m_Email; }
			set { m_Email = value; }
		}

        ///<summary>
        ///Ottiene o imposta la proprietà Password.
        ///</summary>
        private string m_Password;
        [DBAttributes(DbColumnName = "Password")]
        public string Password
        {
            get { return m_Password; }
            set { m_Password = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà Nickname.
        ///</summary>
        private string m_Nickname;
        [DBAttributes(DbColumnName = "Nickname")]
        public string Nickname
        {
            get { return m_Nickname; }
            set { m_Nickname = value; }
        }


        ///<summary>
        ///Ottiene o imposta la proprietà Avatar.
        ///</summary>
        private string m_Immagine;
        [DBAttributes(DbColumnName = "Immagine")]
        public string Immagine
        {
            get { return m_Immagine; }
            set { m_Immagine = value; }
        }

        ///<summary>
		///Ottiene o imposta la proprietà IdUtente.
		///</summary>
		private long m_IdUtente;
        [DBAttributes(DbColumnName = "IdUtente")]
        public long IdUtente
        {
            get { return m_IdUtente; }
            set { m_IdUtente = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà IdFacebook.
        ///</summary>
        private string m_IdFacebook;
        [DBAttributes(DbColumnName = "IdFacebook")]
        public string IdFacebook
        {
            get { return m_IdFacebook; }
            set { m_IdFacebook = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà Cultura.
        ///</summary>
        private string m_Cultura;
        [DBAttributes(DbColumnName = "Cultura")]
        public string Cultura
        {
            get { return m_Cultura; }
            set { m_Cultura = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà Acquisto.
        ///</summary>
        private bool m_Acquisto;
        [DBAttributes(DbColumnName = "Acquisto")]
        public bool Acquisto
        {
            get { return m_Acquisto; }
            set { m_Acquisto = value; }
        }


        ///<summary>
        ///Ottiene o imposta la proprietà PunteggioTotale.
        ///</summary>
        private int m_PunteggioTotale;
        [DBAttributes(DbColumnName = "PunteggioTotale")]
        public int PunteggioTotale
        {
            get { return m_PunteggioTotale; }
            set { m_PunteggioTotale = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà NVittorie.
        ///</summary>
        private int m_NVittorie;
        [DBAttributes(DbColumnName = "NVittorie")]
        public int NVittorie
        {
            get { return m_NVittorie; }
            set { m_NVittorie = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà NPareggi.
        ///</summary>
        private int m_NPareggi;
        [DBAttributes(DbColumnName = "NPareggi")]
        public int NPareggi
        {
            get { return m_NPareggi; }
            set { m_NPareggi = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà NSconfitte.
        ///</summary>
        private int m_NSconfitte;
        [DBAttributes(DbColumnName = "NSconfitte")]
        public int NSconfitte
        {
            get { return m_NSconfitte; }
            set { m_NSconfitte = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà ConteggioParolaPiuLunga.
        ///</summary>
        private int m_ConteggioParolaPiuLunga;
        [DBAttributes(DbColumnName = "ConteggioParolaPiuLunga")]
        public int ConteggioParolaPiuLunga
        {
            get { return m_ConteggioParolaPiuLunga; }
            set { m_ConteggioParolaPiuLunga = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà PunteggioParolaTopScore.
        ///</summary>
        private int m_PunteggioParolaTopScore;
        [DBAttributes(DbColumnName = "PunteggioParolaTopScore")]
        public int PunteggioParolaTopScore
        {
            get { return m_PunteggioParolaTopScore; }
            set { m_PunteggioParolaTopScore = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà ParolaPiuLunga.
        ///</summary>
        private string m_ParolaPiuLunga;
        [DBAttributes(DbColumnName = "ParolaPiuLunga")]
        public string ParolaPiuLunga
        {
            get { return m_ParolaPiuLunga; }
            set { m_ParolaPiuLunga = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà ParolaTopScore.
        ///</summary>
        private string m_ParolaTopScore;
        [DBAttributes(DbColumnName = "ParolaTopScore")]
        public string ParolaTopScore
        {
            get { return m_ParolaTopScore; }
            set { m_ParolaTopScore = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà DataChiusuraUltimaPartita.
        ///</summary>
        private DateTime m_DataChiusuraUltimaPartita;
        [DBAttributes(DbColumnName = "DataChiusuraUltimaPartita")]
        public DateTime DataChiusuraUltimaPartita
        {
            get { return m_DataChiusuraUltimaPartita; }
            set { m_DataChiusuraUltimaPartita = value; }
        }


        ///<summary>
        ///Ottiene o imposta la proprietà NRound.
        ///</summary>
        private int m_NRound;
        [DBAttributes(DbColumnName = "NRound")]
        public int NRound
        {
            get { return m_NRound; }
            set { m_NRound = value; }
        }


        ///<summary>
        ///Ottiene o imposta la proprietà PartitaPersaPrimoTurno.
        ///</summary>
        private bool m_PartitaPersaPrimoTurno;
        [DBAttributes(DbColumnName = "PartitaPersaPrimoTurno")]
        public bool PartitaPersaPrimoTurno
        {
            get { return m_PartitaPersaPrimoTurno; }
            set { m_PartitaPersaPrimoTurno = value; }
        }


        ///<summary>
        ///Ottiene o imposta la proprietà Twister.
        ///</summary>
        private int m_Twister;
        [DBAttributes(DbColumnName = "Twister")]
        public int Twister
        {
            get { return m_Twister; }
            set { m_Twister = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà Bomba.
        ///</summary>
        private int m_Bomba;
        [DBAttributes(DbColumnName = "Bomba")]
        public int Bomba
        {
            get { return m_Bomba; }
            set { m_Bomba = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà Freeze.
        ///</summary>
        private int m_Freeze;
        [DBAttributes(DbColumnName = "Freeze")]
        public int Freeze
        {
            get { return m_Freeze; }
            set { m_Freeze = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà Skip.
        ///</summary>
        private int m_Skip;
        [DBAttributes(DbColumnName = "Skip")]
        public int Skip
        {
            get { return m_Skip; }
            set { m_Skip = value; }
        }

        ///<summary>
        ///Ottiene o imposta la proprietà UltimoAccesso.
        ///</summary>
        private DateTime m_UltimoAccesso;
        [DBAttributes(DbColumnName = "UltimoAccesso")]
        public DateTime UltimoAccesso
        {
            get { return m_UltimoAccesso; }
            set { m_UltimoAccesso = value; }
        }


        #region Membri di IGenericObject
        string it.itryframework2.interfaces.IGenericObject.PrimaryKey
		{
			get { return "IdUtente"; }
		}
		string it.itryframework2.interfaces.IGenericObject.TableName
		{
			get { return "Utenti"; }
		}
		#endregion

	}
}
