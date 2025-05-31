public class AuthService
{
    private ProfissionalDeSaude? _usuarioLogado;

    public ProfissionalDeSaude? UsuarioLogado => _usuarioLogado;

    public bool IsAuthenticated => _usuarioLogado != null;

    public ProfissionalDeSaude? GetUsuarioLogado() => _usuarioLogado;

    public void Login(ProfissionalDeSaude profissional)
    {
        _usuarioLogado = profissional;
    }

    public void Logout()
    {
        _usuarioLogado = null;
    }
}
