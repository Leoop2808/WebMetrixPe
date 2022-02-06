using Brotli.Bundle;
using System.Web;
using System.Web.Optimization;

namespace WebMetrixPe
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BrotliScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new BrotliScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new BrotliScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            /*bundles.Add(new BrotliStyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));*/

            #region Login Master
            bundles.Add(new BrotliStyleBundle("~/Content/login/css").Include(
                      "~/Content/css/estilo1.min.css",
                      "~/Content/css/estilo2.min.css",
                      "~/Content/css/estilo3.min.css",
                      "~/Content/css/estilo4.min.css",
                      "~/Content/css/estilo5.min.css",
                      "~/Content/css/estilo6.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/login/js").Include(
                      "~/Scripts/vendor/global/global.min.js",
                      "~/Scripts/js/custom.min.js",
                      "~/Scripts/js/deznav-init.js"));
            #endregion

            #region Admin Master
            bundles.Add(new BrotliStyleBundle("~/Content/admin/css").Include(
                      "~/Content/css/estilo1.min.css",
                      "~/Content/css/estilo2.min.css",
                      "~/Content/css/estilo3.min.css",
                      "~/Content/css/estilo4.min.css",
                      "~/Content/css/estilo5.min.css",
                      "~/Content/css/estilo6.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/js/global/1").Include(
                      "~/Scripts/vendor/global/global.min.js"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/js/comunes").Include(
                      "~/Scripts/vendor/global/metodoComunes.min.js"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/js/global/2").Include(
                      "~/Scripts/js/custom.min.js",
                      "~/Scripts/js/deznav-init.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/bootstrap_select").Include(
                      "~/Content/vendor/bootstrap-select/dist/css/bootstrap-select.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/bootstrap_select").Include(
                      "~/Scripts/vendor/bootstrap-select/dist/js/bootstrap-select.min.js"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/jquery_validation").Include(
                      "~/Scripts/vendor/jquery-validation/jquery.validate.min.js"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/jquery_validation/init").Include(//este es un ejemplo
                    "~/Scripts/js/plugins-init/jquery.validate-init.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/icons/flaticon").Include(
                     "~/Content/icons/flaticon/flaticon_rutalocal.min.css"));
            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/animate").Include(
                     "~/Content/vendor/animate/animate.min.css"));
            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/aos").Include(
                     "~/Content/vendor/aos/css/aos.min.css"));
            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/perfect_scrollbar").Include(
                     "~/Content/vendor/perfect-scrollbar/css/perfect-scrollbar.min.css"));
            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/metismenu").Include(
                     "~/Content/vendor/metismenu/css/metisMenu.min.css"));
            #endregion

            #region Librerias adicionales
            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/jqueryval").Include(
                        "~/Scripts/vendor/jquery-validation/jquery.validate.min.js"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/jqueryvalunobtrusive").Include(
                        "~/Scripts/vendor/jquery-validation/jquery.validate.unobtrusive.min.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/select2").Include(
                   "~/Content/vendor/select2/css/select2.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/select2").Include(
                      "~/Scripts/vendor/select2/js/select2.full.min.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/lightgallery").Include(
                   "~/Content/vendor/lightgallery/css/lightgallery.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/lightgallery").Include(
                      "~/Scripts/vendor/lightgallery/js/lightgallery-all.min.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/dropzone").Include(
                   "~/Content/vendor/dropzone/dropzone.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/dropzone").Include(
                      "~/Scripts/vendor/dropzone/dropzone.min.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/toastr").Include(
                   "~/Content/vendor/toastr/css/toastr.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/toastr").Include(
                      "~/Scripts/vendor/toastr/js/toastr.min.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/datatables").Include(
                   "~/Content/vendor/datatables/css/jquery.dataTables.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/datatables").Include(
                      "~/Scripts/vendor/datatables/js/jquery.dataTables.min.js"));

            bundles.Add(new BrotliStyleBundle("~/Content/admin/vendor/sweetalert").Include(
                   "~/Content/vendor/sweetalert2/dist/sweetalert2.min.css"));

            bundles.Add(new BrotliScriptBundle("~/bundles/admin/vendor/sweetalert").Include(
                      "~/Scripts/vendor/sweetalert2/dist/sweetalert2.min.js"));
            #endregion

            #region Modulo Prueba

            bundles.Add(new BrotliScriptBundle("~/bundles/js/modulo/prueba/prueba").Include(
                     "~/Scripts/modulos/prueba/prueba.min.js"));

            #endregion

            BundleTable.EnableOptimizations = true;
        }
    }
}
