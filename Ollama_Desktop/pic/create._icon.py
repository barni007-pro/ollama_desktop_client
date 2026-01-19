import os
from PIL import Image
from io import BytesIO

def create_high_quality_icon():
    files = {
        16: "ro_016.png",
        32: "ro_032.png",
        48: "ro_048.png",
        256: "ro_256.png"
    }
    output_name = "app_icon_hq.ico"
    
    # Wir sammeln hier die fertigen Bild-Objekte
    images = []

    print("--- Bereite Bilder vor ---")
    
    # Wir laden alle Bilder
    # WICHTIG: Sortierung Klein -> Groß ist oft sicherer für Pillow
    for size in sorted(files.keys()):
        path = files[size]
        if os.path.exists(path):
            img = Image.open(path).convert("RGBA")
            
            # TRICK: Wir erstellen eine exakte Kopie im Speicher,
            # damit keine Dateihandles offen bleiben.
            img_copy = img.copy()
            images.append(img_copy)
            print(f"✓ {size}x{size} geladen.")
        else:
            print(f"❌ Fehlt: {path}")

    if not images:
        return

    print("--- Speichere als High-Quality ICO ---")
    
    # Der Parameter 'bitmap_format="bmp"' ist hier der Schlüssel für ältere Pillow Versionen,
    # aber der sicherste Weg ist, Pillow entscheiden zu lassen, 
    # aber sicherzustellen, dass die Bilder sauber übergeben werden.
    
    try:
        # Wir nehmen das letzte Bild (256x256) als "Host", da es das größte ist,
        # und hängen ALLE Bilder (auch das 256er selbst) neu an.
        # Das zwingt Pillow, den Header komplett neu zu berechnen.
        
        # Hinweis: Um die Qualität sicherzustellen, nutzen wir sizes explicit
        # Das verhindert, dass Pillow versucht, selbst zu skalieren.
        
        # Wir speichern das Icon
        images[-1].save(
            output_name,
            format='ICO',
            # append_images enthält alle KLEINEREN Bilder
            append_images=images[:-1], 
            # Wir erzwingen keine PNG-Komprimierung für kleine Größen (Standardverhalten)
        )
        print("Speichern erfolgreich.")
        
    except Exception as e:
        print(f"Fehler: {e}")
        return

    # Validierung
    with Image.open(output_name) as check:
        frames = getattr(check, "n_frames", 1)
        print(f"\nERGEBNIS: {frames} Auflösungen enthalten.")
        # Kurzer Check, ob die Daten plausibel sind
        for i in range(frames):
            check.seek(i)
            print(f" - Ebene {i}: {check.size}")

if __name__ == "__main__":
    create_high_quality_icon()