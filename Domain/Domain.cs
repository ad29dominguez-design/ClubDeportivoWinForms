
using System;
using System.Collections.Generic;

namespace ClubDeportivo.Domain
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string Dni { get; set; } = "";
        public string Domicilio { get; set; } = "";
        public string Telefono { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }

        public void RegistraDatos() { }
        public void ModificaDatos() { }
        public override string ToString() => $"{Apellido}, {Nombre} ({Dni})";
    }

    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; } = "";
        public string Passwd { get; set; } = "";
        public string Perfil { get; set; } = "";
        public bool IniciaSesion(string user, string pass) { return true; }
        public void CierraSesion() { }
        public void CambiaPassword(string nueva) { }
        public void ModificaDatos() { }
    }

    public class Administrador : Usuario
    {
        public void OtorgaPermisos(Usuario u, string nuevoPerfil) { }
        public void GeneraReportesDatos() { }
    }

    public class Medico
    {
        public int IdMedico { get; set; }
        public int IdPersona { get; set; }
        public string NumeroMatricula { get; set; } = "";
        public TimeSpan HorarioAtencion { get; set; }
        public string DiasAsignados { get; set; } = "";
        public Persona? Persona { get; set; }
        public void RegistraAsistencia() { }
        public void ConsultaSalud() { }
        public void EmiteHabilitacion() { }
    }

    public class Profesor
    {
        public int IdProfesor { get; set; }
        public int IdPersona { get; set; }
        public string ActividadesAsignadas { get; set; } = "";
        public string HorariosAsignados { get; set; } = "";
        public Persona? Persona { get; set; }
        public void RegistraAsistencia() { }
        public void ConfirmaClase() { }
        public void ConsultaHorario() { }
    }

    public class Socio
    {
        public int IdSocio { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaVencimientoCuota { get; set; }
        public string EstadoMembresia { get; set; } = "ACTIVO";
        public string TipoSocio { get; set; } = "adulto";
        public bool AptoFisico { get; set; }
        public bool PagoCuota { get; set; }
        public Persona? Persona { get; set; }
        public FichaMedica? Ficha { get; set; }
        public List<Cuota> Cuotas { get; set; } = new();
        public void InscripcionActividades() { }
        public void PagaCuota(Cuota c) { }
        public void GeneraComprobantePago() { }
        public void PagaTurno(TurnoNutricion t) { }
        public void GeneraComprobanteTurno() { }
    }

    public class NoSocio
    {
        public int IdNoSocio { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Estado { get; set; } = "ACTIVO";
        public Persona? Persona { get; set; }
        public void InscribeActividades() { }
        public void IngresaComprobantePago() { }
        public void SolicitaTurno() { }
        public void GeneraComprobanteTurno() { }
    }

    public class FichaMedica
    {
        public int IdPersona { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaApto { get; set; }
        public bool AptoFisico { get; set; }
        public string Diagnostico { get; set; } = "";
        public void IngresaDatos() { }
        public void ModificaApto(bool apto) { AptoFisico = apto; }
        public void ModificaDiagnostico(string dx) { Diagnostico = dx; }
        public void OtorgaAptoMedico(bool apto) { AptoFisico = apto; }
    }

    public class Arancel
    {
        public int IdNoSocio { get; set; }
        public string TipoNoSocio { get; set; } = "";
        public decimal ValorArancel { get; set; }
        public bool AnualPago { get; set; }
        public bool MedioPago { get; set; }
        public bool Promo2Cuotas { get; set; }
        public bool Promo3Cuotas { get; set; }
        public bool RegistraPago { get; set; }
        public void RegistrarPago() { }
        public void VerificaEstadoCuota() { }
        public void GeneraComprobantePago() { }
    }

    public class Cuota
    {
        public int IdSocio { get; set; }
        public string TipoCuota { get; set; } = "mensual";
        public DateTime Vencimiento { get; set; }
        public decimal ValorCuota { get; set; }
        public bool MedioPago { get; set; }
        public bool Promo2Cuotas { get; set; }
        public bool Promo3Cuotas { get; set; }
        public bool Pagada { get; set; }
        public void RegistraPago() { Pagada = true; }
        public void NotificaVencimiento() { }
        public bool VerificaEstadoCuota() => Pagada;
    }

    public class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombre { get; set; } = "";
        public int IdProfesor { get; set; }
        public List<Clase> Clases { get; set; } = new();
        public void CrearActividad() { }
        public void ModificarActividad() { }
        public void EliminarActividad() { }
        public void MostrarHorarios() { }
        public void AsignarSalon(int idClase, string salon) { }
    }

    public class Clase
    {
        public int IdClase { get; set; }
        public int IdActividad { get; set; }
        public int IdProfesor { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int Cupo { get; set; }
        public int AsistentesSocios { get; set; }
        public void RegistraAsistenciaProfesor(bool presente) { }
        public void RegistraAsistenciaSocios(int cantidad) { }
        public void RegistraInasistenciaSocios(int cantidad) { }
    }

    public class AsistenciaProfesor
    {
        public int IdClase { get; set; }
        public int IdProfesor { get; set; }
        public bool Asistencia { get; set; }
        public string? MotivoAusencia { get; set; }
        public void RegistraAsistenciaProfesor(bool presente) { Asistencia = presente; }
        public void RegistraMotivoAusencia(string motivo) { MotivoAusencia = motivo; }
    }

    public class Inscripcion
    {
        public int IdPersona { get; set; }
        public int IdActividad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public void InscribeActividades() { }
        public void PagaArancel() { }
        public void GeneraComprobantePago() { }
        public bool VerificaDisponibilidad() { return true; }
    }

    public class Rutina
    {
        public int IdActividad { get; set; }
        public int IdProfesor { get; set; }
        public string? Contenido { get; set; }
        public void CreaRutina(string plan) { Contenido = plan; }
        public void ModificaRutina(string plan) { Contenido = plan; }
        public string ConsultaRutina() => Contenido ?? "";
    }

    public class TurnoNutricion
    {
        public int IdPersona { get; set; }
        public DateTime FechaTurno { get; set; }
        public TimeSpan HoraTurno { get; set; }
        public int IdMedico { get; set; }
        public int IdSocio { get; set; }
        public bool AsignaTurno() { return true; }
        public void CancelaTurno() { }
        public bool VerificaDisponibilidad() { return true; }
    }
}
