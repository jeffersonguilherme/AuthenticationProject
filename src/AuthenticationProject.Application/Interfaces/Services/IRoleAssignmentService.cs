namespace AuthenticationProject.Application.Interfaces.Services;

public interface IRoleAssignmentService
{
    Task<string> ObterRolePorMatriculaAync(string matricula);
}