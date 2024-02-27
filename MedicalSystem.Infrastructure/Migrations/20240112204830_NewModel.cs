using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "Id", "About", "CourseId", "DateUploaded", "LectureDate", "Title" },
                values: new object[,]
                {
                    { 1, "An overview of the basic principles and structures of the human body.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3561), new DateTime(2024, 1, 13, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3566), "Introduction to Human Anatomy" },
                    { 2, "In-depth study of the human skeletal system and its functions.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3583), new DateTime(2024, 1, 14, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3585), "Skeletal System" },
                    { 3, "Understanding the muscles and their role in movement.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3588), new DateTime(2024, 1, 15, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3590), "Muscular System" },
                    { 4, "Exploring the anatomy of the heart and blood vessels.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 1, 16, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3593), "Circulatory System" },
                    { 5, "Study of the lungs and the process of breathing.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 1, 17, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3597), "Respiratory System" },
                    { 6, "Anatomy of the gastrointestinal tract and digestion.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 1, 18, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3603), "Digestive System" },
                    { 7, "Understanding the structure and function of the nervous system.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 1, 19, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3607), "Nervous System" },
                    { 8, "Study of glands and hormones regulating body functions.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 1, 20, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3611), "Endocrine System" },
                    { 9, "Exploration of the anatomy and function of the kidneys and urinary tract.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 1, 21, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3615), "Urinary System" },
                    { 10, "Study of the male and female reproductive organs and their functions.", 1, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3619), new DateTime(2024, 1, 22, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3620), "Reproductive System" },
                    { 11, "An overview of fundamental biochemical processes in living organisms.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3624), new DateTime(2024, 1, 13, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3625), "Introduction to Biochemical Processes" },
                    { 12, "Study of enzyme-catalyzed reactions and their kinetics.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3629), new DateTime(2024, 1, 14, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3631), "Enzyme Kinetics and Catalysis" },
                    { 13, "Understanding the general principles of cellular metabolism.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3633), new DateTime(2024, 1, 15, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3634), "Metabolism: An Overview" },
                    { 14, "Exploration of cell communication through biochemical signaling.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3637), new DateTime(2024, 1, 16, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3638), "Biochemical Signaling Pathways" },
                    { 15, "In-depth study of the structure and function of proteins.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3640), new DateTime(2024, 1, 17, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3641), "Protein Structure and Function" },
                    { 16, "Understanding the role of nucleic acids in storing and transmitting genetic information.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3645), new DateTime(2024, 1, 18, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3646), "Nucleic Acids and Genetic Information" },
                    { 17, "Study of the metabolic pathways involving carbohydrates.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3648), new DateTime(2024, 1, 19, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3649), "Carbohydrate Metabolism" },
                    { 18, "Exploration of the metabolism of lipids and lipid-derived molecules.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3652), new DateTime(2024, 1, 20, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3653), "Lipid Metabolism" },
                    { 19, "Introduction to experimental techniques in biochemistry.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3656), new DateTime(2024, 1, 21, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3657), "Biochemical Techniques" },
                    { 20, "Application of biochemistry in clinical settings and diagnostics.", 2, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 1, 22, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3663), "Clinical Biochemistry" },
                    { 21, "An overview of the basic principles and mechanisms of diseases.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3676), new DateTime(2024, 1, 13, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3677), "Introduction to Medical Pathology" },
                    { 22, "Study of abnormalities at the cellular level in various diseases.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 1, 14, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3682), "Cellular Pathology" },
                    { 23, "Understanding the processes of inflammation and tissue repair.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 1, 15, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3686), "Inflammation and Repair" },
                    { 24, "Study of abnormal growths and tumors in various tissues.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 1, 16, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3690), "Neoplasia" },
                    { 25, "Exploration of diseases affecting the blood and blood-forming tissues.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 1, 17, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3693), "Hematologic Pathology" },
                    { 26, "Study of diseases affecting the heart and blood vessels.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 1, 18, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3698), "Cardiovascular Pathology" },
                    { 27, "Exploration of diseases affecting the respiratory system.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 1, 19, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3701), "Respiratory Pathology" },
                    { 28, "Study of diseases affecting the digestive system.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3704), new DateTime(2024, 1, 20, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3705), "Gastrointestinal Pathology" },
                    { 29, "Understanding diseases affecting the kidneys and urinary tract.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3707), new DateTime(2024, 1, 21, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3708), "Renal Pathology" },
                    { 30, "Study of diseases affecting endocrine glands and hormones.", 3, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 1, 22, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3714), "Endocrine Pathology" },
                    { 31, "Overview of the study of drugs and their effects on the body.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 1, 13, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3722), "Introduction to Pharmacology" },
                    { 32, "Study of drug absorption, distribution, metabolism, and excretion.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 1, 14, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3728), "Pharmacokinetics" },
                    { 33, "Understanding the interactions between drugs and their targets in the body.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 1, 15, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3732), "Pharmacodynamics" },
                    { 34, "Exploration of different classes and categories of drugs.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 1, 16, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3735), "Drug Classes and Categories" },
                    { 35, "Study of unwanted effects and reactions to drugs.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3738), new DateTime(2024, 1, 17, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3739), "Adverse Drug Reactions" },
                    { 36, "In-depth study of drugs targeting bacteria, viruses, and fungi.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3743), new DateTime(2024, 1, 18, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3744), "Antimicrobial Pharmacology" },
                    { 37, "Exploration of drugs affecting the nervous system.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3746), new DateTime(2024, 1, 19, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3747), "Neuropharmacology" },
                    { 38, "Study of drugs affecting the cardiovascular system.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3750), new DateTime(2024, 1, 20, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3751), "Cardiovascular Pharmacology" },
                    { 39, "Understanding drugs used in the management of pain.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3753), new DateTime(2024, 1, 21, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3755), "Pain Management" },
                    { 40, "Application of pharmacological principles in the treatment of common diseases.", 4, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3839), new DateTime(2024, 1, 22, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3841), "Pharmacotherapy of Common Diseases" },
                    { 41, "Overview of essential skills for healthcare professionals.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3851), new DateTime(2024, 1, 13, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3852), "Introduction to Clinical Skills" },
                    { 42, "Developing effective communication techniques with patients.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3858), new DateTime(2024, 1, 14, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3859), "Patient Communication" },
                    { 43, "Mastering the art of collecting comprehensive patient medical histories.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3861), new DateTime(2024, 1, 15, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3863), "Medical History Taking" },
                    { 44, "Learning and practicing various physical examination techniques.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3866), new DateTime(2024, 1, 16, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3867), "Physical Examination Techniques" },
                    { 45, "Understanding and measuring vital signs accurately.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3870), new DateTime(2024, 1, 17, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3871), "Vital Signs Assessment" },
                    { 46, "Ensuring proper infection control measures in clinical settings.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3875), new DateTime(2024, 1, 18, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3876), "Infection Control Practices" },
                    { 47, "Practical skills in wound assessment, cleaning, and dressing.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3879), new DateTime(2024, 1, 19, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3880), "Wound Care and Dressing Techniques" },
                    { 48, "Guidelines and best practices for accurate medical documentation.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3883), new DateTime(2024, 1, 20, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3884), "Medical Documentation" },
                    { 49, "Developing skills for responding to medical emergencies and providing first aid.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3886), new DateTime(2024, 1, 21, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3887), "Emergency Response and First Aid" },
                    { 50, "Understanding and applying ethical principles in healthcare practice.", 5, new DateTime(2024, 1, 12, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 1, 22, 21, 48, 28, 593, DateTimeKind.Local).AddTicks(3893), "Professional Ethics in Healthcare" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 10, 21, 21, 59, 452, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 10, 21, 21, 59, 452, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 10, 21, 21, 59, 452, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 10, 21, 21, 59, 452, DateTimeKind.Local).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 10, 21, 21, 59, 452, DateTimeKind.Local).AddTicks(5955));
        }
    }
}
