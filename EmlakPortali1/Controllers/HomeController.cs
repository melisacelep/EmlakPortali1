using AspNetCoreHero.ToastNotification.Abstractions;
using AutoMapper;
using EmlakPortali1.Models;
using EmlakPortali1.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IlanlarRepository _ilanlarRepository;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;
    private readonly INotyfService _notyf;
    private readonly IFileProvider _fileProvider;
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<AppRole> _roleManager;
    private readonly SignInManager<AppUser> _signInManager;

    public HomeController(
        ILogger<HomeController> logger,
        IlanlarRepository ilanlarRepository,
        IMapper mapper,
        IConfiguration config,
        INotyfService notyf,
        IFileProvider fileProvider,
        UserManager<AppUser> userManager,
        RoleManager<AppRole> roleManager,
        SignInManager<AppUser> signInManager)
    {
        _logger = logger;
        _ilanlarRepository = ilanlarRepository;
        _mapper = mapper;
        _config = config;
        _notyf = notyf;
        _fileProvider = fileProvider;
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _ilanlarRepository.GetAllAsync();
        var activeProducts = products.Where(s => s.IsActive).ToList();
        return View(activeProducts);
    }
}
