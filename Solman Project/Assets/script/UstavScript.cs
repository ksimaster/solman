﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UstavScript : MonoBehaviour
{
    string[] ustavList;
    int randU;
    string pasteText;
    public string labelUstav;

    private void Awake()
    {
        string[] ustavList =  { "Повседневная жизнь и деятельность военнослужащих в воинской части осуществляются в соответствии с требованиями внутренней службы",
                    "Внутренняя служба требует организованных действий военнослужащих независимо от их желаний",
                    "Административную ответственность военнослужащие несут на общих основаниях в соответствии с законодательством об административных правонарушениях",
"Ближайший к подчиненному прямой начальник называется непосредственным начальником",
"В начале прохождения военной службы военнослужащий нуждается в особом внимании.",
"В память о посещении воинской части (корабля) почетными посетителями им представляется для соответствующей записи Книга почетных посетителей",
"В присутствии старшего командира (начальника) команда для воинского приветствия младшему не подается и доклад не проводится",
"В штабах и в учреждениях приветствуются по команде только прямые начальники и лица, назначенные для руководства проведением инспектирования (проверки)",
"Взаимоотношения между военнослужащими строятся на основе взаимного уважения",
"Вне строя, отдавая или получая приказ, военнослужащие обязаны принять строевую стойку, а при надетом головном уборе приложить к нему руку и опустить ее",
"Во внеслужебное время и вне строя офицеры могут обращаться друг к другу не только по воинскому званию, но и по имени и отчеству",
"Военная служба - особый вид государственной службы",
"Военная форма одежды и знаки различия утверждаются Президентом Российской Федерации",
"Военнослужащему не могут отдаваться приказы и распоряжения, ставиться задачи, не имеющие отношения к военной службе или направленные на нарушение закона",
"Военнослужащие без головного убора сопровождают рукопожатие легким наклоном головы",
"Военнослужащие обязаны оказывать уважение друг другу, содействовать командирам (начальникам) и старшим в поддержании порядка и дисциплины",
"Военнослужащие представляются своим непосредственным начальникам при награждении орденом или медалью",
"Военнослужащие представляются своим непосредственным начальникам при назначении на воинскую должность",
"Военнослужащие представляются своим непосредственным начальникам при присвоении воинского звания",
"Военнослужащие представляются своим непосредственным начальникам при сдаче воинской должности",
"Военнослужащие представляются своим непосредственным начальникам при убытии в командировку, на лечение или в отпуск и по возвращении",
"Военнослужащие при исполнении обязанностей военной службы являются представителями государственной власти и находятся под защитой государства",
"Военнослужащие, находящиеся вне строя, при исполнении гимна принимают строевую стойку, а при надетом головном уборе прикладывают к нему руку",
"Военнослужащий в целях успешного выполнения поставленной ему задачи обязан проявлять разумную инициативу",
"Военнослужащий обязан беспрекословно повиноваться командирам (начальникам) и защищать их в бою, оберегать Боевое Знамя воинской части",
"Военнослужащий обязан быть бдительным, строго хранить военную и государственную тайну",
"Военнослужащий обязан быть честным, дисциплинированным, храбрым, при выполнении воинского долга проявлять разумную инициативу",
"Военнослужащий обязан знать и содержать в постоянной готовности к применению вверенные ему вооружение и военную технику, беречь военное имущество",
"Военнослужащий обязан постоянно овладевать военными профессиональными знаниями, совершенствовать свою выучку и воинское мастерство",
"Военнослужащий обязан проявлять патриотизм, дорожить интернациональной дружбой народов, способствовать укреплению братства между нациями и народностями.",
"Военнослужащий обязан соблюдать правила воинской вежливости, поведения и выполнения воинского приветствия, всегда быть по форме, чисто и аккуратно одетым",
"Военнослужащий, захваченный противником в плен, при допросе имеет право сообщить только свою фамилию, имя, отчество, воинское звание, дату рождения и личный номер",
"Военнослужащий, получив приказ, отвечает: <<Есть>> - и затем выполняет его",
"Воинское приветствие является воплощением товарищеской сплоченности военнослужащих, свидетельством взаимного уважения и проявлением общей культуры.",
"Выполнение требований внутренней службы развивает у военнослужащих чувство ответственности, самостоятельность, аккуратность и добросовестность.",
"Для военнослужащих Вооруженных Сил Российской Федерации устанавливаются необходимые виды формы одежды",
"Должностные обязанности используются только в интересах службы",
"Единоначалие является одним из принципов строительства Вооруженных Сил Российской Федерации, руководства ими и взаимоотношений между военнослужащими",
"Если старший без перчаток, младший перед рукопожатием снимает перчатку с правой руки",
"За действия, унижающие человеческое достоинство подчиненного, начальник несет ответственность",
"За совершенные правонарушения военнослужащие привлекаются, как правило, к одному виду ответственности",
"Защита Отечества - священный долг и обязанность каждого гражданина Российской Федерации.",
"Каждому военнослужащему присваивается соответствующее воинское звание",
"Командир (начальник) перед отдачей приказа обязан всесторонне оценить обстановку и предусмотреть меры по обеспечению его выполнения",
"Командир полка представляет вновь прибывших офицеров офицерскому составу полка на ближайшем совещании офицеров или построении полка",
"Лица гражданского персонала Вооруженных Сил Российской Федерации являются начальниками для подчиненных в соответствии с занимаемой штатной должностью.",
"Меры общественного воздействия могут быть применены к военнослужащим за проступки, связанные с нарушением ими воинской дисциплины и общественного порядка.",
"На общих собраниях личного состава для воинского приветствия подается команда <<Смирно>> или <<Встать.Смирно>> и докладывается командиру (начальнику).",
"Начальник имеет право отдавать подчиненному приказы и требовать их исполнения",
"Начальники, которым военнослужащие подчинены по службе, хотя бы и временно, являются прямыми начальниками",
"Непосредственным организатором внутренней службы в воинской части является начальник штаба, а в расположении роты - старшина роты",
"Никто не вправе ограничивать военнослужащих в правах, гарантированных Конституцией Российской Федерации и законодательством",
"О всем случившемся с военнослужащим, влияющем на исполнение его обязанностей, и сделанных ему замечаниях он обязан докладывать своему непосредственному начальнику",
"О выполнении полученного приказа военнослужащий обязан доложить начальнику, отдавшему приказ, и своему непосредственному начальнику",
"О каждом случае применения или использования оружия военнослужащий докладывает командиру (начальнику)",
"Обсуждение приказа недопустимо, а неповиновение или другое неисполнение приказа является воинским преступлением",
"Ответственность за состояние внутренней службы в подчиненных войсках возлагается на всех прямых начальников",
"Отдавший новый приказ сообщает об этом начальнику, отдавшему первый приказ",
"По личным вопросам военнослужащий также должен обращаться к непосредственному начальнику, а в случае особой необходимости - к старшему начальнику",
"По своему служебному положению и воинскому званию одни военнослужащие по отношению к другим могут быть начальниками или подчиненными",
"По служебным вопросам военнослужащий должен обращаться к своему непосредственному начальнику и с его разрешения к следующему по команде начальнику",
"Подразделения, участвующие в похоронной процессии, воинское приветствие не выполняют",
"Подчиненные и младшие по воинскому званию приветствуют первыми, а при равном положении первым приветствует тот, кто считает себя более вежливым и воспитанным.",
"Подчиненные и младшие, обращаясь по службе к начальникам и старшим, называют их по воинскому званию, добавляя перед званием слово <<товарищ>>",
"Подчиненный обязан беспрекословно выполнять приказы начальника. Выполнив приказ, он может подать жалобу, если считает, что по отношению к нему поступили неправильно",
"Права военнослужащих и порядок их реализации с учетом особенностей военной службы определяются законодательством Российской Федерации",
"Представляясь своему непосредственному начальнику, военнослужащие называют свою воинскую должность, воинское звание, фамилию и причину представления",
"При крайней необходимости старший начальник может отдать приказ подчиненному, минуя его непосредственного начальника",
"При личном обращении воинское звание называется без указания рода войск или службы",
"При обращении к другому военнослужащему в присутствии командира (начальника) или старшего у него необходимо спросить на это разрешение",
"При обучении и воспитании военнослужащих должно проявляться уважение к их национальным чувствам, обычаям и традициям",
"При посещении инспектирующим (проверяющим) подразделений командиры этих подразделений встречают его и докладывают ему.",
"При приветствии в строю в движении начальник подает только команду",
"При привлечении к ответственности недопустимо ущемление чести и достоинства военнослужащих.",
"При проведении классных занятий команда <<Смирно>>, <<Встать.Смирно>> или <<Товарищи офицеры>> подается перед каждым занятием и по его окончании",
"При рукопожатии старший подает руку первым",
"Прибывшему в воинскую часть старшему командиру (начальнику) представляется только командир части",
"Приказ (приказание) должен соответствовать требованиям законов и воинских уставов",
"Приказ должен быть сформулирован ясно, не допускать двоякого толкования и не вызывать сомнения у подчиненного",
"Приказ командира (начальника) должен быть выполнен беспрекословно, точно и в срок",
"Приказание - форма доведения командиром (начальником) задач до подчиненных по частным вопросам",
"Приказание отдается в письменном виде или устно",
"Приказы отдаются в порядке подчиненности",
"Применению оружия должно предшествовать предупреждение о намерении его применить",
"Руководство внутренней службой в воинской части осуществляет командир воинской части, а в расположении подразделения - командир подразделения.",
"Старшинство определяется воинскими званиями военнослужащих",
"Строгий контроль со стороны командиров (начальников) и их личный пример помогают военнослужащему быстрее уяснить правила внутренней службы",
"Требования внутренней службы обязан знать и добросовестно выполнять каждый военнослужащий",
"Трезвый образ жизни должен быть повседневной нормой поведения всех военнослужащих",
"Уголовную ответственность военнослужащие несут за совершенные преступления в соответствии с законодательством Российской Федерации",
"Устные приказы отдаются всеми командирами (начальниками)." }; 
    }

    public void GetUstavText()
    { 
        randU = Random.Range(0, ustavList.Length);
        pasteText = ustavList[randU];

    }







}
