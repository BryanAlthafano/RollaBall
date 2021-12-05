Documentasi Project

BolaController 
public float speed; (Mensetup bola/player agar dapat bergerak/dikendalikan)
public Rigidbody rigidbody; (Mensetup bola/player dalam mengatur gravitasi pada suatu objek)
public Text textCount; (Sebagai ruang kosong untuk tempat text perhitungan nilai/poin)
public Text textWin; (Sebagai ruang kosong untuk tempat text menang apabila dapat meraih semua objek/poin)

CameraController (Mensetup camera agar dapat mengikuti gerak bola)
public GameObject player;
private Vector3 offset;

Perputaran (Mensetup rotasi gerak pada capsul agar tidak hanya diam)

ButtonController
public void ButtonRestart(); (Sebagai button untuk restart/memulai ulang game)
public void Exit(); (Sebagai button untuk keluar game)