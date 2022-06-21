# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from ... import batch as _batch
from ... import core as _core
from ... import meta as _meta

__all__ = [
    'CronJobSpecArgs',
    'CronJobStatusArgs',
    'CronJobArgs',
    'JobTemplateSpecArgs',
]

@pulumi.input_type
class CronJobSpecArgs:
    def __init__(__self__, *,
                 job_template: pulumi.Input['JobTemplateSpecArgs'],
                 schedule: pulumi.Input[str],
                 concurrency_policy: Optional[pulumi.Input[str]] = None,
                 failed_jobs_history_limit: Optional[pulumi.Input[int]] = None,
                 starting_deadline_seconds: Optional[pulumi.Input[int]] = None,
                 successful_jobs_history_limit: Optional[pulumi.Input[int]] = None,
                 suspend: Optional[pulumi.Input[bool]] = None):
        """
        CronJobSpec describes how the job execution will look like and when it will actually run.
        :param pulumi.Input['JobTemplateSpecArgs'] job_template: Specifies the job that will be created when executing a CronJob.
        :param pulumi.Input[str] schedule: The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.
        :param pulumi.Input[str] concurrency_policy: Specifies how to treat concurrent executions of a Job. Valid values are: - "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one
        :param pulumi.Input[int] failed_jobs_history_limit: The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        :param pulumi.Input[int] starting_deadline_seconds: Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.
        :param pulumi.Input[int] successful_jobs_history_limit: The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        :param pulumi.Input[bool] suspend: This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.
        """
        pulumi.set(__self__, "job_template", job_template)
        pulumi.set(__self__, "schedule", schedule)
        if concurrency_policy is not None:
            pulumi.set(__self__, "concurrency_policy", concurrency_policy)
        if failed_jobs_history_limit is not None:
            pulumi.set(__self__, "failed_jobs_history_limit", failed_jobs_history_limit)
        if starting_deadline_seconds is not None:
            pulumi.set(__self__, "starting_deadline_seconds", starting_deadline_seconds)
        if successful_jobs_history_limit is not None:
            pulumi.set(__self__, "successful_jobs_history_limit", successful_jobs_history_limit)
        if suspend is not None:
            pulumi.set(__self__, "suspend", suspend)

    @property
    @pulumi.getter(name="jobTemplate")
    def job_template(self) -> pulumi.Input['JobTemplateSpecArgs']:
        """
        Specifies the job that will be created when executing a CronJob.
        """
        return pulumi.get(self, "job_template")

    @job_template.setter
    def job_template(self, value: pulumi.Input['JobTemplateSpecArgs']):
        pulumi.set(self, "job_template", value)

    @property
    @pulumi.getter
    def schedule(self) -> pulumi.Input[str]:
        """
        The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.
        """
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: pulumi.Input[str]):
        pulumi.set(self, "schedule", value)

    @property
    @pulumi.getter(name="concurrencyPolicy")
    def concurrency_policy(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies how to treat concurrent executions of a Job. Valid values are: - "Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one
        """
        return pulumi.get(self, "concurrency_policy")

    @concurrency_policy.setter
    def concurrency_policy(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "concurrency_policy", value)

    @property
    @pulumi.getter(name="failedJobsHistoryLimit")
    def failed_jobs_history_limit(self) -> Optional[pulumi.Input[int]]:
        """
        The number of failed finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        """
        return pulumi.get(self, "failed_jobs_history_limit")

    @failed_jobs_history_limit.setter
    def failed_jobs_history_limit(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "failed_jobs_history_limit", value)

    @property
    @pulumi.getter(name="startingDeadlineSeconds")
    def starting_deadline_seconds(self) -> Optional[pulumi.Input[int]]:
        """
        Optional deadline in seconds for starting the job if it misses scheduled time for any reason.  Missed jobs executions will be counted as failed ones.
        """
        return pulumi.get(self, "starting_deadline_seconds")

    @starting_deadline_seconds.setter
    def starting_deadline_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "starting_deadline_seconds", value)

    @property
    @pulumi.getter(name="successfulJobsHistoryLimit")
    def successful_jobs_history_limit(self) -> Optional[pulumi.Input[int]]:
        """
        The number of successful finished jobs to retain. This is a pointer to distinguish between explicit zero and not specified.
        """
        return pulumi.get(self, "successful_jobs_history_limit")

    @successful_jobs_history_limit.setter
    def successful_jobs_history_limit(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "successful_jobs_history_limit", value)

    @property
    @pulumi.getter
    def suspend(self) -> Optional[pulumi.Input[bool]]:
        """
        This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.  Defaults to false.
        """
        return pulumi.get(self, "suspend")

    @suspend.setter
    def suspend(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "suspend", value)


@pulumi.input_type
class CronJobStatusArgs:
    def __init__(__self__, *,
                 active: Optional[pulumi.Input[Sequence[pulumi.Input['_core.v1.ObjectReferenceArgs']]]] = None,
                 last_schedule_time: Optional[pulumi.Input[str]] = None):
        """
        CronJobStatus represents the current state of a cron job.
        :param pulumi.Input[Sequence[pulumi.Input['_core.v1.ObjectReferenceArgs']]] active: A list of pointers to currently running jobs.
        :param pulumi.Input[str] last_schedule_time: Information when was the last time the job was successfully scheduled.
        """
        if active is not None:
            pulumi.set(__self__, "active", active)
        if last_schedule_time is not None:
            pulumi.set(__self__, "last_schedule_time", last_schedule_time)

    @property
    @pulumi.getter
    def active(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['_core.v1.ObjectReferenceArgs']]]]:
        """
        A list of pointers to currently running jobs.
        """
        return pulumi.get(self, "active")

    @active.setter
    def active(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['_core.v1.ObjectReferenceArgs']]]]):
        pulumi.set(self, "active", value)

    @property
    @pulumi.getter(name="lastScheduleTime")
    def last_schedule_time(self) -> Optional[pulumi.Input[str]]:
        """
        Information when was the last time the job was successfully scheduled.
        """
        return pulumi.get(self, "last_schedule_time")

    @last_schedule_time.setter
    def last_schedule_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "last_schedule_time", value)


@pulumi.input_type
class CronJobArgs:
    def __init__(__self__, *,
                 api_version: Optional[pulumi.Input[str]] = None,
                 kind: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input['_meta.v1.ObjectMetaArgs']] = None,
                 spec: Optional[pulumi.Input['CronJobSpecArgs']] = None,
                 status: Optional[pulumi.Input['CronJobStatusArgs']] = None):
        """
        CronJob represents the configuration of a single cron job.
        :param pulumi.Input[str] api_version: APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        :param pulumi.Input[str] kind: Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        :param pulumi.Input['_meta.v1.ObjectMetaArgs'] metadata: Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        :param pulumi.Input['CronJobSpecArgs'] spec: Specification of the desired behavior of a cron job, including the schedule. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        :param pulumi.Input['CronJobStatusArgs'] status: Current status of a cron job. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        if api_version is not None:
            pulumi.set(__self__, "api_version", 'batch/v2alpha1')
        if kind is not None:
            pulumi.set(__self__, "kind", 'CronJob')
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if spec is not None:
            pulumi.set(__self__, "spec", spec)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="apiVersion")
    def api_version(self) -> Optional[pulumi.Input[str]]:
        """
        APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        """
        return pulumi.get(self, "api_version")

    @api_version.setter
    def api_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "api_version", value)

    @property
    @pulumi.getter
    def kind(self) -> Optional[pulumi.Input[str]]:
        """
        Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        """
        return pulumi.get(self, "kind")

    @kind.setter
    def kind(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "kind", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input['_meta.v1.ObjectMetaArgs']]:
        """
        Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input['_meta.v1.ObjectMetaArgs']]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def spec(self) -> Optional[pulumi.Input['CronJobSpecArgs']]:
        """
        Specification of the desired behavior of a cron job, including the schedule. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        return pulumi.get(self, "spec")

    @spec.setter
    def spec(self, value: Optional[pulumi.Input['CronJobSpecArgs']]):
        pulumi.set(self, "spec", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input['CronJobStatusArgs']]:
        """
        Current status of a cron job. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input['CronJobStatusArgs']]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class JobTemplateSpecArgs:
    def __init__(__self__, *,
                 metadata: Optional[pulumi.Input['_meta.v1.ObjectMetaArgs']] = None,
                 spec: Optional[pulumi.Input['_batch.v1.JobSpecArgs']] = None):
        """
        JobTemplateSpec describes the data a Job should have when created from a template
        :param pulumi.Input['_meta.v1.ObjectMetaArgs'] metadata: Standard object's metadata of the jobs created from this template. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        :param pulumi.Input['_batch.v1.JobSpecArgs'] spec: Specification of the desired behavior of the job. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if spec is not None:
            pulumi.set(__self__, "spec", spec)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input['_meta.v1.ObjectMetaArgs']]:
        """
        Standard object's metadata of the jobs created from this template. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input['_meta.v1.ObjectMetaArgs']]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def spec(self) -> Optional[pulumi.Input['_batch.v1.JobSpecArgs']]:
        """
        Specification of the desired behavior of the job. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        """
        return pulumi.get(self, "spec")

    @spec.setter
    def spec(self, value: Optional[pulumi.Input['_batch.v1.JobSpecArgs']]):
        pulumi.set(self, "spec", value)


