#include <iostream>
#include <string>
#include <curl/curl.h>

// Función callback para recibir la respuesta del servidor
size_t WriteCallback(void* contents, size_t size, size_t nmemb, std::string* output) {
    size_t totalSize = size * nmemb;
    output->append((char*)contents, totalSize);
    return totalSize;
}

int main() {
    CURL* curl;
    CURLcode res;
    std::string readBuffer;

    curl = curl_easy_init();
    if (curl) {
        std::string url = "https://paginas-web-cr.com/Api/apis/ListaCurso.php";

        // Configurar la solicitud POST
        curl_easy_setopt(curl, CURLOPT_URL, url.c_str());
        curl_easy_setopt(curl, CURLOPT_POST, 1L);

        // Registrar la función que guarda la respuesta
        curl_easy_setopt(curl, CURLOPT_WRITEFUNCTION, WriteCallback);
        curl_easy_setopt(curl, CURLOPT_WRITEDATA, &readBuffer);

        // Ejecutar la solicitud
        res = curl_easy_perform(curl);

        if (res != CURLE_OK) {
            std::cerr << "❌ Error en la solicitud CURL: " << curl_easy_strerror(res) << std::endl;
        }
        else {
            std::cout << "✅ Respuesta de la API:\n" << readBuffer << std::endl;
        }

        curl_easy_cleanup(curl);
    }
    else {
        std::cerr << "No se pudo inicializar CURL." << std::endl;
    }

    return 0;
}
