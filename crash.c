#include <openssl/ssl.h>

void crash(const char* ca_file)
{
    printf("running crash function\n");

    SSL_CTX* ctx = SSL_CTX_new(TLSv1_2_client_method());
    if (!ctx) {
        printf("failed to create ssl context\n");
        return;
    }

    int ret = SSL_CTX_load_verify_locations(ctx, ca_file, NULL);
    if (!ret) {
        printf("load verify locations error, cafile: %s\n", ca_file);
    } else {
        printf("Did not crash!\n");
    }
}
